using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace Task
{
    class Listt
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "EnableIntubation", "EnableCPR_VerificationMode", "EnableChestTube", "EnableCriticalCare", "EnableSmokingCessation", "EnableCentralLines", "EnableDermabondLac", "EnableModerateSedation", "EnableFloorCall", "EnableCovid19", "EnableMVA", "EnableUnreadableChart", "EnableExcessiveBilling", "EnableImproperBilling", "EnableIdentifiedOverpayment", "EnableUnifiedProgramIntegrityContractor", "EnableComprehensiveErrorRateTesting", "EnableUHCHearing", "EnableOfficeOfInspectorGeneral", "EnableAttorneyGeneral", "EnableAuditReport", "EnableWorkersCompensation_VerificationMode" };

            foreach (string s in list.ToList())
            {
                if (!s.ToLower().Contains("verificationmode"))
                {
                    list.Remove(s);
                }
                else
                {
                    int index = list.IndexOf(s);
                    string[] strList = s.Split('_');
                    list[index] = strList[0];
                }

            }

            // List<string> List2 = new List<string>();
            //for (int i =list.Count-1; i >=0; i--) 
            //{
            //    string s = list[i];
            //    if (s.ToLower().Contains("verificationmode"))
            //    {
            //        string[] strList = s.Split('_');
            //        list[i]= strList[0];
            //    }
            //    else
            //    {
            //        list.RemoveAt(i);
            //    }
            //}
            

            foreach (string s in list)
            {
               Console.WriteLine(s);
            }
        }
    }
}
