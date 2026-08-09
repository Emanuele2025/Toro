using System;
using System.Collections.Generic;
using System.Text;

namespace Toro.Modelli
{
    public class DtoContattiVcf
    {
        public string Nome { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Note { get; set; } = string.Empty;

        public DtoContattiVcf()
        {
        }

        public DtoContattiVcf(string percorsoNomeFile)
        {
            if (!File.Exists(percorsoNomeFile))
            {
                return;
            }

            string[] lines = File.ReadAllLines(percorsoNomeFile);

            foreach (string line in lines)
            {
                if (line.StartsWith("FN:", StringComparison.OrdinalIgnoreCase))
                {
                    Nome = line.Substring(3).Trim();
                }
                else if (line.StartsWith("EMAIL;", StringComparison.OrdinalIgnoreCase))
                {
                    int posizione = line.IndexOf(':');

                    if (posizione >= 0)
                    {
                        Email = line.Substring(posizione + 1).Trim();
                    }
                }
                else if (line.StartsWith("NOTE;", StringComparison.OrdinalIgnoreCase))
                {
                    int posizione = line.IndexOf(':');

                    if (posizione >= 0)
                    {
                        Note = line.Substring(posizione + 1).Trim();
                    }
                }
            }
        }

        public List<DtoContattiVcf> Contatti(string percorsoFilesVcf)
        {
            List<DtoContattiVcf> returnContatti = new List<DtoContattiVcf>();

            if (!Directory.Exists(percorsoFilesVcf))
            {
                return returnContatti;
            }

            foreach (string fileVcf in Directory.EnumerateFiles(
                percorsoFilesVcf,
                "*.vcf",
                SearchOption.TopDirectoryOnly))
            {
                try
                {
                    DtoContattiVcf contatto = new DtoContattiVcf(fileVcf);

                    returnContatti.Add(contatto);
                }
                catch (IOException)
                {
                     
                    continue;
                }
                catch (UnauthorizedAccessException)
                {
                    
                    continue;
                }
            }

            return returnContatti;
        }
    }

}
