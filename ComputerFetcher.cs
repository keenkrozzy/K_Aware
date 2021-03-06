﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;
using System.Windows.Forms;

namespace K_Aware
{
    public class ComputerFetcher
    {
        public static List<string> GetComputers()
        {
            List<string> computerNames = new List<string>();

            using (DirectoryEntry entry = new DirectoryEntry("LDAP://andent.andersonsinc.com"))
            {
                using (DirectorySearcher mySearcher = new DirectorySearcher(entry))
                {
                    mySearcher.Filter = ("(objectClass=computer)");

                    // No size limit, reads all objects
                    mySearcher.SizeLimit = 0;

                    // Read data in pages of 250 objects. Make sure this value is below the limit configured in your AD domain (if there is a limit)
                    mySearcher.PageSize = 250;

                    // Let searcher know which properties are going to be used, and only load those
                    mySearcher.PropertiesToLoad.Add("name");

                    foreach (SearchResult resEnt in mySearcher.FindAll())
                    {
                        // Note: Properties can contain multiple values.
                        if (resEnt.Properties["name"].Count > 0)
                        {
                            string computerName = (string)resEnt.Properties["name"][0];
                            computerNames.Add(computerName);
                        }
                    }
                }
            }

			MessageBox.Show(computerNames.Count().ToString());

            return computerNames;
        }
    }
}
