using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejestracje
{
    internal class RegisterDataBase
    {
        private List<RegisterData> _registerDataList;

        public RegisterDataBase()
        {
            InitializeList();
        }

        public RegisterData GetRegisterDataByRegisterNumber(string registerNumber)
        {
            RegisterData result;

            result = _registerDataList.FirstOrDefault(reg => reg.RegisterNumber == registerNumber);


            return result;
        }


        private void InitializeList()
        {
            _registerDataList = new List<RegisterData>();
            _registerDataList.Add(new RegisterData("DBL", "Bolesławiec", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DGL", "Głogów", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DJA", "Jawor", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DJE", "Jelenia Góra", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DKL", "Kłodzko", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DLE", "Legnica ", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DLU", "Lubin", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DMI", "Milcz", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DOA", "Oława", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DST", "Strzelin", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DSW", "Świdnica", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DB", "Wałbrzych", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DWL", "Wołów", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DWR", "Wrocław ", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DZG", "Zgorzelec", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DDZ", "Dzierżoniów", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DGR", "Góra", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DDJ", "Jelenia Góra", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DKA", "Kamienna Góra", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DL", "Legnica", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DLB", "Lubań", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DLW", "Lwówek Śląski", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DOL", "Oleśnica", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DPL", "Polkowice", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DSR", "Środa Śląska", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DTR", "Trzebnica", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DBA", "Wałbrzych (Powiat)", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DW", "Wrocław", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DZA", "Ząbkowice Śląskie", "Dolnośląskie"));
            _registerDataList.Add(new RegisterData("DZL", "Złotoryja", "Dolnośląskie"));


            _registerDataList.Add(new RegisterData("CAL", "Aleksandrów Kujawski", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CB", "Bydgoszcz", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CCH", "Chełmno", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CG", "Grudziądz", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CIN", "Inowrocław", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CMG", "Mogilno ", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CRA", "Radziejów", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CSE", "Sępólno Krajeńskie", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CT", "Toruń", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CTU", "Tuchola", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CW", "Włocławek", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CZN", "Żnin", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CBR", "Bydgoszcz (Powiat)", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CBY", "Golub Dobrzyń ", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CGD", "Grudziądz (Powiat)", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CGR", "Lipno", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CLI", "Nakło Nad Notecią", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CNA", "Rypin", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CRY", "Świecie", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CSW", "Toruń (Powiat)", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CTR", "Wąbrzeźno", "KUJAWSKO-POMORSKIE"));
            _registerDataList.Add(new RegisterData("CWA", "Włocławek (Powiat)", "KUJAWSKO-POMORSKIE"));
        }
    }
}