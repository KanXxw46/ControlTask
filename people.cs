using System;
using System.Collections.Generic;
using System.Text;

namespace ControlWork_StarWors_
{
    public class people
    {
		public Guid Id { get; set; } = Guid.NewGuid();
		public string Name { get; set; }
		public string stringheight { get; set; }
	    public string stringmass { get; set; }
        public string stringhair_color { get; set; }
		public string stringskin_color { get; set; }
		public string stringeye_color { get; set; }
	    public string stringbirth_year { get; set; }
		public string stringgender { get; set; }

	}
}
