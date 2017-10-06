using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K_Aware
{
	public class KAComputer
	{
		string strName;

		public string name
		{
			get
			{
				return strName;
			}

			set
			{
				strName = value;
			}
		}

		public KAComputer(string _strName)
		{
			strName = _strName;
		}
	}
}
