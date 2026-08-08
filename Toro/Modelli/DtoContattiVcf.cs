using System;
using System.Collections.Generic;
using System.Text;

namespace Toro.Modelli
{
    public class DtoContattiVcf
    {
        public string Nome { get; set; } = "";

        public string Email { get; set; } = ""; 

        public string Note { get; set; } = "";

        public DtoContattiVcf() 
        { 
        
        }

        public DtoContattiVcf(string percorsoNomeFile)

        {

            string[] lines = File.ReadAllLines(percorsoNomeFile);

            if (lines.Length >= 4)

            {

                Nome = lines?.Where(p => p.Contains("FN:"))?.FirstOrDefault() ?? "";

                Nome = Nome?.Replace("FN:", "") ?? "";

                Email = lines?.Where(p => p.Contains("EMAIL;PREF;INTERNET:"))?.FirstOrDefault() ?? "";

                Email = Email?.Replace("EMAIL;PREF;INTERNET:", "") ?? "";

                Note = lines?.Where(p => p.Contains("NOTE;ENCODING=QUOTED-PRINTABLE:"))?.FirstOrDefault() ?? "";

                Note = Note?.Replace("NOTE;ENCODING=QUOTED-PRINTABLE:", "") ?? "";

            }

        }

        public List<DtoContattiVcf> Contatti(string percorsoFilesVcf)

        {

            List<DtoContattiVcf> returnContatti = new List<DtoContattiVcf>();

            try

            {
                Int32 numeroFilesVCf = Directory.GetFiles(percorsoFilesVcf, "*.vcf", SearchOption.TopDirectoryOnly).Length;
                if (numeroFilesVCf == 0)
                {
                    return returnContatti;
                }

                foreach (string fileVcs in Directory.EnumerateFiles(percorsoFilesVcf))
                {
                    //Verifico se ha l'estensione vcf
                    if (Path.GetExtension(fileVcs).ToLower() != ".vcf")
                    {
                        continue;
                    }   
                    DtoContattiVcf contatto = new DtoContattiVcf(fileVcs);

                    returnContatti.Add(contatto);

                }



            }

            catch (Exception)
            {


            }

            return returnContatti;

        }





    }
}
