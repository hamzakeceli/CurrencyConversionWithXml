using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace KurConvert
{
    public partial class Kur : Form
    {
        public Kur()
        {
            InitializeComponent();
        }
        //Xml den okunan birim adı ve fiyatı tutulur.
        Dictionary<string, double> UnitInformation = new Dictionary<string, double>();

        private void Form1_Load(object sender, EventArgs e)
        {
                       
            string xmlPath = Application.StartupPath + @"\..\..\KurBilgileri.xml";
            XmlRead(xmlPath);
            PriceAndNameFillToCombobox();

        }
        //xml'den kur aadlarını ve değerlerini okuma
        public void XmlRead(string path)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            //Hangi node bilgiler alınacak
            XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Tarih_Date/Currency");


            UnitInformation.Add("TURK LİRASI", 1);// TL elle ekledik sitede olmadığı için

            foreach (XmlNode item in xmlNodeList)
            {
                // kur adlarını ve fiyatlarını aldık
                string unitName = item["Isim"].InnerText;
                string buyingPrice = item["ForexBuying"].InnerText;

                //double . görmediği için , çevirdik
                buyingPrice = buyingPrice.Replace(".", ",");

                double buyingPricee = Convert.ToDouble(buyingPrice);

                // Listeye ad ve fiyat doldurma
                UnitInformation.Add(unitName, buyingPricee);

            }
           
           
        }

        //comboboxlara tüm birim adı ve fiyatları eklenmesi
        private void PriceAndNameFillToCombobox()
        {
            cmbEnteredUnit.DataSource = UnitInformation.Keys.ToArray();
            cmbResultUnit.DataSource = UnitInformation.Keys.ToArray();
        }

        private void btnCalculater_Click(object sender, EventArgs e)
        {

            string enteredUnit = cmbEnteredUnit.SelectedItem.ToString();
            string resultUnit = cmbResultUnit.SelectedItem.ToString();            
            double enteredUnitPrice,resultUnitPrice;

            //Listeden girilen birimlerin fiyatlarını çekme
            bool isEnteredUnit=UnitInformation.TryGetValue(enteredUnit, out enteredUnitPrice);
            bool isResultUnit = UnitInformation.TryGetValue(resultUnit, out resultUnitPrice);

            //labellara birim fiyatları yazdırma
            lblEnteredUnitPrice.Text = enteredUnitPrice.ToString()+"TL";
            lblResultUnitiPrice.Text = resultUnitPrice.ToString()+"TL";


            if (isEnteredUnit && isResultUnit && txtEnteredValue.Text!="")
            {
                double enteredValue = Convert.ToDouble(txtEnteredValue.Text);
                double result= KurConvertCalculater(enteredUnitPrice, resultUnitPrice, enteredValue);
                lblResultValue.Text = result.ToString();

            }
            else
            {
                MessageBox.Show("Fiyat bilgisini giriniz");
            }
            
        }
            
        
        //kur fiyatalrının birbirine çevirme
        private double KurConvertCalculater(double enteredUnitPrice, double resultUnitPrice, double enteredValue)
        {
            double result = (enteredUnitPrice * enteredValue) / resultUnitPrice;
            return result;
        }
    }
}
