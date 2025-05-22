# Class és konstruktor

```c#
 public class Foglalas
        {
            public int sorSzam;
            public int szobaSzam;
            public int elsoNap;
            public int utolsoNap;
            public int letSzam;
            public string reggeli;
            public string nev;
            public int year;

            public Foglalas(string lines, int year)
            {
                string[] parts = lines.Split(' ');
               
                this.sorSzam = int.Parse(parts[0]);
                this.szobaSzam = int.Parse(parts[1]);
                this.elsoNap = int.Parse(parts[2]);
                this.utolsoNap = int.Parse(parts[3]);
                this.letSzam = int.Parse(parts[4]);
                this.reggeli = parts[5];
                this.nev = parts[6];

                this.reggeli = parts[5] == "1" ? "1" : "0";
                
                this.year = year;
            }

            public class Arak
            {
                public string szezon;
                public DateTime szezonkezd;
                public DateTime szezonzar;
                public int ar;

                public Arak(string lines2)
                {
                    string[] parts2 = lines2.Split(';');
                    this.szezon = parts2[0];
                    this.szezonkezd = DateTime.Parse(parts2[1]);
                    this.szezonzar = DateTime.Parse(parts2[2]);
                    this.ar = int.Parse(parts2[3]);
                }
            }
        }
```