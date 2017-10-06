using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace K_Aware
{
	public class XMLHead
	{
		public KAComputer[] aComputers = new KAComputer[0];

		public XMLHead()
		{
			
		}

		public void Write(string _strFileName, string _strRootElement, string[] _astrValues)
		{
			using (XmlWriter writer = XmlWriter.Create(String.Concat(@"\\andent.andersonsinc.com\home\users$\KB143686\K_Aware\", _strFileName, @".xml")))
			{
				writer.WriteStartDocument();
				writer.WriteStartElement(_strRootElement);

				if (_astrValues != null)
				{
					foreach (string strV in _astrValues)
					{
						writer.WriteStartElement("Computer");
						writer.WriteElementString("Name", strV);
						writer.WriteEndElement();
					}
				}
				writer.WriteEndElement();
				writer.WriteEndDocument();
			}
		}

		public void Read(string _strFileName)
		{
			using (XmlReader reader = XmlReader.Create(String.Concat(@"\\andent.andersonsinc.com\home\users$\KB143686\K_Aware\", _strFileName, @".xml")))
			{
				while (reader.Read())
				{
					if (reader.IsStartElement())
					{
						switch (reader.Name)
						{
							case "Name":
								if (reader.Read())
								{
									aComputers = aComputers.Concat(new KAComputer[] { new KAComputer(reader.Value.Trim()) }).ToArray();
								}

								
								break;
						}

					}

				}
			}


		}
//		using (XmlWriter writer = XmlWriter.Create("employees.xml"))
//        {
//            writer.WriteStartDocument();
//            writer.WriteStartElement("Employees");

//            foreach (Employee employee in employees)
//            {
//                writer.WriteStartElement("Employee");

//                writer.WriteElementString("ID", employee.Id.ToString());
//                writer.WriteElementString("FirstName", employee.FirstName);
//                writer.WriteElementString("LastName", employee.LastName);
//                writer.WriteElementString("Salary", employee.Salary.ToString());

//                writer.WriteEndElement();
//            }

//writer.WriteEndElement();
//            writer.WriteEndDocument();
//        }


	}
}
