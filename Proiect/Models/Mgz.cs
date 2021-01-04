using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Proiect.Models
{
    public class Mgz
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Denumire { get; set; }
        public string Description { get; set; }
        public string ObservableCollection { get; set; }

        // public DateTime Date { get; set; }
       
      
    







}









}
