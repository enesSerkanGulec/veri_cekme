using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] kullanılanTaglar = new string[] { "ManufacturerCode", "Manufacturer", "Name", "OrginalNo", "VehicleBrand", "VehicleType", "Price", "PriceCurrency", "Quantity", "Picture" };

        string[] özelDurumlar = new string[] { "Quantity;VAR;5", "VehicleType;HAF.TİCARİ;HAFİF TİCARİ", "VehicleType;AĞIRVASITA;AĞIR VASITA", "VehicleBrand;RVI;RENAULT", "VehicleBrand;SSANG YONG;SSANGYON", "VehicleBrand;NİSSAN;NISSAN", "VehicleBrand;MİTSUBISHI=MITSUBISHI", "VehicleBrand;İVECO;IVECO", "VehicleBrand;SPR VAG;MERCEDES", "VehicleBrand;KHD;DEUTZ" };
        //Bu dizide ilkBölüm Alan, ikinci gelenVeri ve üçüncü ise düzeltilecek değerdir.
        class Item
        {
            string toXmlTag(string başlık, string içerik)
            {
                return "<" + başlık + ">" + düzelt(içerik) + "</" + başlık + ">";
            }
            string düzelt(string içerik)
            {
                ///&lt;  	< 	less than
                ///&gt;     > 	greater than
                ///&amp; 	& 	ampersand 
                ///&apos; 	' 	apostrophe
                ///&quot; 	" 	quotation mark
                if (içerik == null) return null;
                içerik = içerik.Replace("&", "&amp;");
                içerik = içerik.Replace("<", "&lt;");
                içerik = içerik.Replace(">", "&gt;");
                içerik = içerik.Replace("'", "&apos;");
                içerik = içerik.Replace("\"", "&quot;");
                return içerik;
            }
            public string toXmlString(string başlık = "item")
            {
                return "<" + başlık + ">" + toXmlTag(nameof(stockCode), stockCode) + toXmlTag(nameof(label), label) + toXmlTag(nameof(status), status) + toXmlTag(nameof(brand), brand) + toXmlTag(nameof(brandId), brandId) + toXmlTag(nameof(barcode), barcode) + toXmlTag(nameof(mainCategory), mainCategory) + toXmlTag(nameof(category), category) + toXmlTag(nameof(subCategory), subCategory) + toXmlTag(nameof(buyingPrice), buyingPrice) + toXmlTag(nameof(price1), price1) + toXmlTag(nameof(price2), price2) + toXmlTag(nameof(price3), price3) + toXmlTag(nameof(price4), price4) + toXmlTag(nameof(price5), price5) + toXmlTag(nameof(tax), tax) + toXmlTag(nameof(currencyAbbr), currencyAbbr) + toXmlTag(nameof(stockAmount), stockAmount) + toXmlTag(nameof(stockType), stockType) + toXmlTag(nameof(warranty), warranty) + toXmlTag(nameof(picture1Path), picture1Path) + toXmlTag(nameof(picture2Path), picture2Path) + toXmlTag(nameof(picture3Path), picture3Path) + toXmlTag(nameof(picture4Path), picture4Path) + toXmlTag(nameof(dm3), dm3) + toXmlTag(nameof(details), details) + toXmlTag(nameof(rebate), rebate) + toXmlTag(nameof(rebateType), rebateType) + toXmlTag(nameof(variants), variants) + toXmlTag(nameof(specs), specs) + "</" + başlık + ">\n";
            }
            public void içeAktar(XmlNode v)
            {
                //XmlNode v = veri;
                stockCode = v["ManufacturerCode"].InnerText;
                label = v["Manufacturer"].InnerText + " " + v["ManufacturerCode"].InnerText + " " + v["Name"].InnerText + " " + v["OrginalNo"].InnerText + " " + v["VehicleBrand"].InnerText;
                status = "1";
                brand = v["Manufacturer"].InnerText;
                mainCategory = v["VehicleType"].InnerText;
                category = v["VehicleBrand"].InnerText;
                price1 = v["Price"].InnerText;
                tax = "18";
                currencyAbbr = v["PriceCurrency"].InnerText;
                stockAmount = v["Quantity"].InnerText;
                stockType = "Adet";
                warranty = "0";
                picture1Path = v["Picture"].InnerText;
                details = "<span style=\"font-family: Tahoma, Geneva, sans-serif; font-size: 14pt\">" + v["Manufacturer"].InnerText + " " + v["ManufacturerCode"].InnerText + " " + v["Name"].InnerText + " " + v["OrginalNo"].InnerText + " " + v["VehicleBrand"].InnerText + "</span>";
            }
            public string stockCode;
            #region Alanlar
            public string label;
            public string status;
            public string brand;
            public string brandId;
            public string barcode;
            public string mainCategory;
            public string category;
            public string subCategory;
            public string buyingPrice;
            public string price1;
            public string price2;
            public string price3;
            public string price4;
            public string price5;
            public string tax;
            public string currencyAbbr;
            public string stockAmount;
            public string stockType;
            public string warranty;
            public string picture1Path;
            public string picture2Path;
            public string picture3Path;
            public string picture4Path;
            public string dm3;
            public string details;
            public string rebate;
            public string rebateType;
            public string variants;
            public string specs;
            #endregion
        }

        void özeldurumKontrol(XmlNode v)
        {
            for (int i = 0; i < özelDurumlar.Length; i++)
            {
                string[] s = özelDurumlar[i].Split(';');
                XmlNode x = v.SelectSingleNode(s[0]);
                if (x == null) continue;
                if (x.InnerText == s[1])
                    x.InnerText = s[2];
            }
        }

        bool tagkontrol(XmlNode v)
        {
            for (int i = 0; i < kullanılanTaglar.Length; i++)
                if (v.SelectSingleNode(kullanılanTaglar[i]) == null)
                    return false;
            return true;
        }
        void verileriÇek(int sonLimit = 120000, int paket = 5000)
        {
            DateTime t = DateTime.Now;
            int adet = 0;
            int parti = (sonLimit / paket) + (sonLimit % paket == 0 ? 0 : 1);
            string s = "";
            XmlDocument xml;
            XmlNode[] elemanlar = new XmlNode[0];
            if (saveFileDialog2.ShowDialog() == DialogResult.Cancel) return;
            //StreamWriter writer = new StreamWriter(, true, Encoding.UTF8);
            FileStream dosya = new FileStream(saveFileDialog2.FileName, FileMode.Create);
            StreamWriter writer = new StreamWriter(dosya, Encoding.UTF8);
            writer.Write("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<root>\n");
            for (int i = 0; i < parti; i++)
            {
                label3.Text = (i + 1).ToString() + " / " + parti.ToString() + "       Veri Çekiliyor";
                this.Refresh();
                int baş = i * paket + 1;
                int bit = ((i + 1) * paket) > sonLimit ? sonLimit : ((i + 1) * paket);
                s = veriÇek(baş, bit);
                if (s == "-1") break;
                if (s == "")
                {
                    MessageBox.Show((i + 1).ToString() + ". veri paketi çekilirken veri paketi boş döndü. Bu son paketler için bir problem oluşturmaz. Fakat daha ilk pakette ise tekrar deneyiniz.", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                label3.Text = (i + 1).ToString() + " / " + parti.ToString() + "       Veri İşleniyor";
                this.Refresh();
                xml = new XmlDocument();
                xml.LoadXml(s);

                //XmlNode[] elemlist = xml.GetElementsByTagName("Item").Cast<XmlNode>().ToArray();
                XmlNodeList elemlist = xml.GetElementsByTagName("Item");
                if (elemlist.Count == 0)
                {
                    MessageBox.Show((i + 1).ToString() + ". veri paketi çekilirken veri paketi boş döndü. Bu son paketler için bir problem oluşturmaz. Fakat daha ilk pakette ise blok miktarını azalatıp tekrar deneyiniz.", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }


                if (i == 0)
                    if (!tagkontrol(elemlist[0]))
                    {
                        MessageBox.Show("Çekilen veri alanları ile dönüşümde ullandığımız alanlar uyuşmuyor.\nİşlem İptal ediliyor..", "Hata !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        label3.Text = "İşlem iptal edildi...";
                        return;
                    }


                Item item = new Item();
                for (int j = 0; j < elemlist.Count; j += 2) // Veri Tekrarı olduğundan şimdilik bir atlayarak alıyor.
                {
                    if (!tümVeriToolStripMenuItem.Checked)
                    {

                        if (resmiOlanlarToolStripMenuItem.Checked && elemlist[j].SelectSingleNode("Picture").InnerText == "") continue;
                        if (fiyat0DanBüyükOlanlarToolStripMenuItem.Checked)
                        {
                            string f = elemlist[j].SelectSingleNode("Price").InnerText;
                            decimal fiyat;
                            if (!decimal.TryParse(f, out fiyat)) fiyat = 0;
                            if (fiyat == 0) continue;
                        }
                    }
                    özeldurumKontrol(elemlist[j]);
                    item.içeAktar(elemlist[j]);
                    writer.Write(item.toXmlString());
                    adet++;
                }

            }
            writer.Write("</root>");
            writer.Close();
            dosya.Close();
            label3.Text = "işlem tamamlandı.. "+ DateTime.Now.Subtract(t).TotalSeconds.ToString() + " saniye sürdü. Toplam satır sayısı: " + adet.ToString();
            System.Media.SystemSounds.Beep.Play();
        }
        string veriÇek(int başlama = 1, int bitiş = 2)
        {
            try
            {
                var jSonYapi = new { companyKey = "954FCD2D", functionName = "GetProductList_Atamer", userName = "atamer_motorasin", password = "dDKs3dfyQH", dataType = "xml", parameters = new { pStart = başlama, pEnd = bitiş } };
                var json = JsonConvert.SerializeObject(jSonYapi);
                var client = new RestClient("http://share.eryaz.net/api/integration/getdata");
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("Accept", "application/xml");
                request.AddParameter("application/json", json, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                return response.Content;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu. İşlem İptal edildi. Orjinal hata mesajı:\n" + hata.Message);
                return "-1";
            }
        }
        void tree_yeAktar(XmlNodeList düğümler, TreeNode treeDüğüm)
        {
            foreach (var düğüm in düğümler)
            {

                if (((XmlNode)düğüm).HasChildNodes)
                {
                    TreeNode x = treeDüğüm.Nodes.Add(((XmlNode)düğüm).Name);
                    tree_yeAktar(((XmlNode)düğüm).ChildNodes, x);
                }
                else
                {
                    if (((XmlNode)düğüm).InnerText == "")
                        treeDüğüm.Nodes.Add(((XmlNode)düğüm).Name);
                    else
                        treeDüğüm.Nodes.Add(((XmlNode)düğüm).InnerText);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verileriÇek((int)numericUpDown2.Value, (int)numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = numericUpDown2.Value;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void tümVeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tümVeriToolStripMenuItem.Checked = true;
            fiyat0DanBüyükOlanlarToolStripMenuItem.Checked = resmiOlanlarToolStripMenuItem.Checked = false;
        }

        private void fiyat0DanBüyükOlanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fiyat0DanBüyükOlanlarToolStripMenuItem.Checked = !fiyat0DanBüyükOlanlarToolStripMenuItem.Checked;
            tümVeriToolStripMenuItem.Checked = !fiyat0DanBüyükOlanlarToolStripMenuItem.Checked && !resmiOlanlarToolStripMenuItem.Checked;
        }

        private void resmiOlanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resmiOlanlarToolStripMenuItem.Checked = !resmiOlanlarToolStripMenuItem.Checked;
            tümVeriToolStripMenuItem.Checked = !fiyat0DanBüyükOlanlarToolStripMenuItem.Checked && !resmiOlanlarToolStripMenuItem.Checked;
        }
    }
}
