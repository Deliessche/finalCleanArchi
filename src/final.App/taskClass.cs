using System;
using System.IO;

namespace final.App
{
	public class taskClass{
		string year, month, day, name, hour;
		public taskClass(string _year, string _month, string _day, string _hour, string _name){
			this.year = _year;
			this.month = _month;
			this.day = _day;
			this.hour = _hour;
			this.name = _name;
		}
		public string Name {get;}
		public string taskDate (){
			return year + month + day + " " + hour; 
		}
	}
}