﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LanacHotela
{
    public class GostHotela : Osoba
    {
        private int idGost;
        private static int idBrojac = 1234;
        private string brojLicnailiPasosa;
        private Kartica platnaKartica;

        public GostHotela(string ime, string prezime, string korisnickoIme, string sifra, Image slika, string jmbg, DateTime datumRodjenja, 
                          string email, string brojTelefona, string brojLicnailiPasosa, Kartica platnaKartica) : base(ime, prezime, korisnickoIme, sifra, slika, jmbg, datumRodjenja, email, brojTelefona)
        {
            this.IdGost = idBrojac++;
            this.brojLicnailiPasosa = brojLicnailiPasosa;
            this.platnaKartica = platnaKartica;
        }

        public global::System.String BrojLicnailiPasosa { get => brojLicnailiPasosa; set => brojLicnailiPasosa = value; }
        internal Kartica PlatnaKartica { get => platnaKartica; set => platnaKartica = value; }
        public int IdGost { get => idGost; set => idGost = value; }
    }
}
