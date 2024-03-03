using System;
namespace KurucuFonksiyonlar{
    class Program{
        public static void Main(string[] args){

            string[] calisanBilgileri = {"name","surName","age","department"};
            //Calisan calisan1 = new Calisan("yalcin","mrl",23424,"dep");
            Calisan calisan1 = new Calisan();
            calisan1.calisanList.Add("Ayse");
            calisan1.calisanList.Add("tan");
            calisan1.calisanList.Add("86655");
            calisan1.calisanList.Add("department");
            calisan1.CalisanYazdir(calisanBilgileri);

            Calisan calisan2 = new Calisan("yalcin","mrl",23424,"dep");
            calisan2.CalisanYazdir(calisanBilgileri);
        }
    }
    class Calisan{
        public string ad;
        public string soyAd;
        public int no;
        public string department;
        public List<string> calisanList = new List<string>();
        public Calisan(){}
        public Calisan(string ad,string soyAd,int no,string department){
            this.ad = ad;
            this.soyAd = soyAd;
            this.no = no;
            this.department = department;
            calisanList.Add(this.ad);
            calisanList.Add(this.soyAd);
            calisanList.Add(this.no.ToString());
            calisanList.Add(this.department);

        }
        public void CalisanYazdir(string[] bilgiler){
            int i = 0;
            foreach(var calisan in bilgiler){
                Console.WriteLine(calisan + " : " + calisanList[i++]);
            }
        }
    }
}