using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp2.Models
{
    public class VeriTabani
    {
        private static Dictionary<string, DavetiyeModel> _liste;

        //SANAL VERİTABANI
        static VeriTabani() //constructor
        {
            _liste = new Dictionary<string, DavetiyeModel>();
            _liste.Add("Hasan", new DavetiyeModel
            {
                Ad = "Hasan",
                Eposta = "hasan61@gmail.com",
                KatilmaDurumu = true
            });

            _liste.Add("Gökhan", new DavetiyeModel
            {
                Ad = "Gökhan",
                Eposta = "gokhanyzc9797@gmail.com",
                KatilmaDurumu = true
            });

            _liste.Add("Melike", new DavetiyeModel
            {
                Ad = "Melike",
                Eposta = "melikevarlik@gmail.com",
                KatilmaDurumu = false

            });

        }
            public static void Add(DavetiyeModel model)
            {
                string key = model.Ad.ToLower(); //Tolower, string'e atanan metnin tüm karakterlerini küçük harfe çevirmemizi sağlar.
                if (_liste.ContainsKey(key))
                {
                    _liste[key] = model;

                }

                else
                {
                    _liste.Add(key, model);
                }
            }

            public static IEnumerable<DavetiyeModel> Liste
        {
            get { return _liste.Values; }
        }
    }
}

