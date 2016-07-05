using System;

namespace FieldGenerator
{
    class FieldGenerator
    {
        // Peremennie
        private string zoloto = "zoloto";
        private string serebro = "serebro";
        private string bronza = "bronza";
        private string nicego = "nicego";
        private int width;
        private int height;

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        // Funktsija dlja zadaci pozitsij elementov na pole
        public string[,] СreateField()
        {

            int wirina = Width - 1;
            int visota = Height - 1;
            // Sozdaem pole s zadannimi razmerami
            string[,] massPole = new string[Width, Height];

            // Opredeljaem slucajnoe polozenie zolota
            int numberX = new Random().Next(0, wirina);
            int numberY = new Random().Next(0, visota);

            // Zadaem polozenie elementov
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (y == numberY)
                    {
                        if (x == numberX)
                        {
                            massPole[x, y] = zoloto;
                        }
                        else if (x == numberX - 1 || x == numberX + 1)
                        {
                            massPole[x, y] = serebro;
                        }
                        else if (x == numberX - 2 || x == numberX + 2)
                        {
                            massPole[x, y] = bronza;
                        }
                        else massPole[x, y] = nicego;
                    }
                    else if (y == numberY - 1)
                    {
                        if (x == numberX - 1 || x == numberX || x == numberX + 1)
                        {
                            massPole[x, y] = serebro;
                        }
                        else if (x == numberX - 2 || x == numberX + 2)
                        {
                            massPole[x, y] = bronza;
                        }
                        else massPole[x, y] = nicego;
                    }
                    else if (y == numberY - 2)
                    {
                        if (x == numberX - 2 || x == numberX - 1 || x == numberX || x == numberX + 1 || x == numberX + 2)
                        {
                            massPole[x, y] = bronza;
                        }
                        else massPole[x, y] = nicego;
                    }
                    else if (y == numberY + 1)
                    {
                        if (x == numberX - 1 || x == numberX || x == numberX + 1)
                        {
                            massPole[x, y] = serebro;
                        }
                        else if (x == numberX - 2 || x == numberX + 2)
                        {
                            massPole[x, y] = bronza;
                        }
                        else massPole[x, y] = nicego;
                    }
                    else if (y == numberY + 2)
                    {
                        if (x == numberX - 2 || x == numberX - 1 || x == numberX || x == numberX + 1 || x == numberX + 2)
                        {
                            massPole[x, y] = bronza;
                        }
                        else massPole[x, y] = nicego;
                    }
                    else massPole[x, y] = nicego;
                }

                if (numberX == 0)
                {
                    if (numberY == 0)
                    {
                        //serebro
                        massPole[wirina, 0] = serebro;
                        massPole[wirina, 1] = serebro;

                        massPole[0, visota] = serebro;
                        massPole[1, visota] = serebro;

                        massPole[wirina, visota] = serebro;

                        //bronza
                        massPole[(wirina - 1), 0] = bronza;
                        massPole[(wirina - 1), 1] = bronza;
                        massPole[(wirina - 1), 2] = bronza;
                        massPole[wirina, 2] = bronza;

                        massPole[2, visota] = bronza;
                        massPole[2, (visota - 1)] = bronza;
                        massPole[1, (visota - 1)] = bronza;
                        massPole[0, (visota - 1)] = bronza;

                        massPole[wirina, (visota - 1)] = bronza;
                        massPole[(wirina - 1), (visota - 1)] = bronza;
                        massPole[(wirina - 1), visota] = bronza;

                    }
                    else if (numberY == 1)
                    {
                        //serebro
                        massPole[wirina, 0] = serebro;
                        massPole[wirina, 1] = serebro;
                        massPole[wirina, 2] = serebro;

                        //bronza
                        massPole[(wirina - 1), 0] = bronza;
                        massPole[(wirina - 1), 1] = bronza;
                        massPole[(wirina - 1), 2] = bronza;
                        massPole[(wirina - 1), 3] = bronza;
                        massPole[wirina, 3] = bronza;

                        massPole[0, visota] = bronza;
                        massPole[1, visota] = bronza;
                        massPole[2, visota] = bronza;

                        massPole[(wirina - 1), visota] = bronza;
                        massPole[wirina, visota] = bronza;

                    }
                    else if (numberY == (visota - 1))
                    {
                        //serebro
                        massPole[wirina, visota] = serebro;
                        massPole[wirina, (visota - 1)] = serebro;
                        massPole[wirina, (visota - 2)] = serebro;

                        //bronza
                        massPole[(wirina - 1), visota] = bronza;
                        massPole[(wirina - 1), (visota - 1)] = bronza;
                        massPole[(wirina - 1), (visota - 2)] = bronza;
                        massPole[(wirina - 1), (visota - 3)] = bronza;
                        massPole[wirina, (visota - 3)] = bronza;

                        massPole[0, 0] = bronza;
                        massPole[1, 0] = bronza;
                        massPole[2, 0] = bronza;

                        massPole[(wirina - 1), 0] = bronza;
                        massPole[wirina, 0] = bronza;

                    }
                    else if (numberY == visota)
                    {
                        //serebro
                        massPole[0, 0] = serebro;
                        massPole[1, 0] = serebro;

                        massPole[wirina, visota] = serebro;
                        massPole[wirina, (visota - 1)] = serebro;

                        massPole[wirina, 0] = serebro;

                        //bronza
                        massPole[0, 1] = bronza;
                        massPole[1, 1] = bronza;
                        massPole[2, 1] = bronza;
                        massPole[2, 0] = bronza;

                        massPole[(wirina - 1), visota] = bronza;
                        massPole[(wirina - 1), (visota - 1)] = bronza;
                        massPole[(wirina - 1), (visota - 2)] = bronza;
                        massPole[wirina, (visota - 2)] = bronza;

                        massPole[(wirina - 1), 0] = bronza;
                        massPole[(wirina - 1), 1] = bronza;
                        massPole[wirina, 1] = bronza;

                    }
                    else
                    {
                        //serebro
                        massPole[wirina, numberY] = serebro;
                        massPole[wirina, (numberY - 1)] = serebro;
                        massPole[wirina, (numberY + 1)] = serebro;

                        //bronza
                        massPole[wirina, (numberY - 2)] = bronza;
                        massPole[wirina, (numberY + 2)] = bronza;
                        massPole[(wirina - 1), (numberY - 2)] = bronza;
                        massPole[(wirina - 1), (numberY - 1)] = bronza;
                        massPole[(wirina - 1), numberY] = bronza;
                        massPole[(wirina - 1), (numberY + 1)] = bronza;
                        massPole[(wirina - 1), (numberY + 2)] = bronza;

                    }
                }

                else if (numberX == 1)
                {
                    if (numberY == 0)
                    {
                        //serebro
                        massPole[0, visota] = serebro;
                        massPole[1, visota] = serebro;
                        massPole[2, visota] = serebro;

                        //bronza
                        massPole[0, (visota - 1)] = bronza;
                        massPole[1, (visota - 1)] = bronza;
                        massPole[2, (visota - 1)] = bronza;
                        massPole[3, (visota - 1)] = bronza;
                        massPole[3, visota] = bronza;

                        massPole[wirina, visota] = bronza;
                        massPole[wirina, (visota - 1)] = bronza;

                        massPole[wirina, 0] = bronza;
                        massPole[wirina, 1] = bronza;
                        massPole[wirina, 2] = bronza;

                    }
                    else if (numberY == 1)
                    {
                        //bronza
                        massPole[wirina, visota] = bronza;

                        massPole[0, visota] = bronza;
                        massPole[1, visota] = bronza;
                        massPole[2, visota] = bronza;
                        massPole[3, visota] = bronza;

                        massPole[wirina, 0] = bronza;
                        massPole[wirina, 1] = bronza;
                        massPole[wirina, 2] = bronza;
                        massPole[wirina, 3] = bronza;

                    }
                    else if (numberY == (visota - 1))
                    {
                        //bronza
                        massPole[wirina, 0] = bronza;

                        massPole[0, 0] = bronza;
                        massPole[1, 0] = bronza;
                        massPole[2, 0] = bronza;
                        massPole[3, 0] = bronza;

                        massPole[wirina, visota] = bronza;
                        massPole[wirina, (visota - 1)] = bronza;
                        massPole[wirina, (visota - 2)] = bronza;
                        massPole[wirina, (visota - 3)] = bronza;

                    }
                    else if (numberY == visota)
                    {
                        //serebro
                        massPole[0, 0] = serebro;
                        massPole[1, 0] = serebro;
                        massPole[2, 0] = serebro;

                        //bronza
                        massPole[wirina, 0] = bronza;
                        massPole[wirina, 1] = bronza;

                        massPole[0, 1] = bronza;
                        massPole[1, 1] = bronza;
                        massPole[2, 1] = bronza;
                        massPole[3, 1] = bronza;
                        massPole[3, 0] = bronza;

                        massPole[wirina, visota] = bronza;
                        massPole[wirina, (visota - 1)] = bronza;
                        massPole[wirina, (visota - 2)] = bronza;

                    }
                    else
                    {
                        //bronza
                        massPole[wirina, numberY] = bronza;
                        massPole[wirina, (numberY - 1)] = bronza;
                        massPole[wirina, (numberY - 2)] = bronza;
                        massPole[wirina, (numberY + 1)] = bronza;
                        massPole[wirina, (numberY + 2)] = bronza;

                    }
                }

                else if (numberX == (wirina - 1))
                {
                    if (numberY == 0)
                    {
                        //serebro
                        massPole[wirina, visota] = serebro;
                        massPole[(wirina - 1), visota] = serebro;
                        massPole[(wirina - 2), visota] = serebro;

                        //bronza
                        massPole[0, 0] = bronza;
                        massPole[0, 1] = bronza;
                        massPole[0, 2] = bronza;

                        massPole[0, visota] = bronza;
                        massPole[0, (visota - 1)] = bronza;

                        massPole[wirina, (visota - 1)] = bronza;
                        massPole[(wirina - 1), (visota - 1)] = bronza;
                        massPole[(wirina - 2), (visota - 1)] = bronza;
                        massPole[(wirina - 3), (visota - 1)] = bronza;
                        massPole[(wirina - 3), visota] = bronza;

                    }
                    else if (numberY == 1)
                    {
                        //bronza
                        massPole[wirina, visota] = bronza;
                        massPole[(wirina - 1), visota] = bronza;
                        massPole[(wirina - 2), visota] = bronza;
                        massPole[(wirina - 3), visota] = bronza;

                        massPole[0, 0] = bronza;
                        massPole[0, 1] = bronza;
                        massPole[0, 2] = bronza;
                        massPole[0, 3] = bronza;

                        massPole[0, visota] = bronza;

                    }
                    else if (numberY == (visota - 1))
                    {
                        //bronza
                        massPole[0, 0] = bronza;

                        massPole[0, visota] = bronza;
                        massPole[0, (visota - 1)] = bronza;
                        massPole[0, (visota - 2)] = bronza;
                        massPole[0, (visota - 3)] = bronza;

                        massPole[wirina, 0] = bronza;
                        massPole[(wirina - 1), 0] = bronza;
                        massPole[(wirina - 2), 0] = bronza;
                        massPole[(wirina - 3), 0] = bronza;

                    }
                    else if (numberY == visota)
                    {
                        //serebro
                        massPole[wirina, visota] = serebro;
                        massPole[(wirina - 1), visota] = serebro;
                        massPole[(wirina - 2), visota] = serebro;

                        //bronza
                        massPole[wirina, (visota - 1)] = bronza;
                        massPole[(wirina - 1), (visota - 1)] = bronza;
                        massPole[(wirina - 2), (visota - 1)] = bronza;
                        massPole[(wirina - 3), (visota - 1)] = bronza;
                        massPole[(wirina - 3), visota] = bronza;

                        massPole[0, 0] = bronza;
                        massPole[0, 1] = bronza;

                        massPole[0, visota] = bronza;
                        massPole[0, (visota - 1)] = bronza;
                        massPole[0, (visota - 2)] = bronza;
                        
                    }
                    else
                    {
                        //bronza
                        massPole[0, (numberY +2)] = bronza;
                        massPole[0, (numberY + 1)] = bronza;
                        massPole[0, numberY] = bronza;
                        massPole[0, (numberY - 1)] = bronza;
                        massPole[0, (numberY - 2)] = bronza;

                    }
                }

                else if (numberX == wirina)
                {
                    if (numberY == 0)
                    {
                        //serebro
                        massPole[0, 0] = serebro;
                        massPole[0, 1] = serebro;

                        massPole[0, visota] = serebro;

                        massPole[wirina, visota] = serebro;
                        massPole[(wirina - 1), visota] = serebro;

                        //bronza
                        massPole[0, 3] = bronza;
                        massPole[1, 3] = bronza;
                        massPole[1, 2] = bronza;
                        massPole[1, 1] = bronza;
                        massPole[1, 0] = bronza;

                        massPole[1, visota] = bronza;
                        massPole[1, (visota - 1)] = bronza;
                        massPole[0, (visota - 1)] = bronza;

                        massPole[wirina, (visota - 1)] = bronza;
                        massPole[(wirina - 1), (visota - 1)] = bronza;
                        massPole[(wirina - 2), (visota - 1)] = bronza;
                        massPole[(wirina - 2), visota] = bronza;

                    }
                    else if (numberY == 1)
                    {
                        //serebro
                        massPole[0, 0] = serebro;
                        massPole[0, 1] = serebro;
                        massPole[0, 2] = serebro;

                        //bronza
                        massPole[1, 0] = bronza;
                        massPole[1, 1] = bronza;
                        massPole[1, 2] = bronza;
                        massPole[1, 3] = bronza;
                        massPole[0, 3] = bronza;

                        massPole[0, visota] = bronza;
                        massPole[1, visota] = bronza;

                        massPole[wirina, visota] = bronza;
                        massPole[(wirina - 1), visota] = bronza;
                        massPole[(wirina - 2), visota] = bronza;

                    }
                    else if (numberY == (visota - 1))
                    {
                        //serebro
                        massPole[0, visota] = serebro;
                        massPole[0, (visota - 1)] = serebro;
                        massPole[0, (visota - 2)] = serebro;

                        //bronza
                        massPole[1, visota] = bronza;
                        massPole[1, (visota - 1)] = bronza;
                        massPole[1, (visota - 2)] = bronza;
                        massPole[1, (visota - 3)] = bronza;
                        massPole[0, (visota - 3)] = bronza;

                        massPole[wirina, 0] = bronza;
                        massPole[(wirina - 1), 0] = bronza;
                        massPole[(wirina - 2), 0] = bronza;

                        massPole[0, 0] = bronza;
                        massPole[1, 0] = bronza;

                    }
                    else if (numberY == visota)
                    {
                        //serebro
                        massPole[wirina, 0] = serebro;
                        massPole[(wirina - 1), 0] = serebro;

                        massPole[0, 0] = serebro;

                        massPole[0, visota] = serebro;
                        massPole[0, (visota - 1)] = serebro;

                        //bronza
                        massPole[wirina, 1] = bronza;
                        massPole[(wirina - 1), 1] = bronza;
                        massPole[(wirina - 2), 1] = bronza;
                        massPole[(wirina - 2), 0] = bronza;

                        massPole[0, 1] = bronza;
                        massPole[1, 1] = bronza;
                        massPole[1, 0] = bronza;

                        massPole[1, visota] = bronza;
                        massPole[1, (visota - 1)] = bronza;
                        massPole[1, (visota - 2)] = bronza;
                        massPole[0, (visota - 2)] = bronza;

                    }
                    else
                    {
                        //serebro
                        massPole[0, (numberY - 1)] = serebro;
                        massPole[0, numberY] = serebro;
                        massPole[0, (numberY + 1)] = serebro;

                        //bronza
                        massPole[0, (numberY - 2)] = bronza;
                        massPole[1, (numberY - 2)] = bronza;
                        massPole[1, (numberY - 1)] = bronza;
                        massPole[1, numberY] = bronza;
                        massPole[1, (numberY + 1)] = bronza;
                        massPole[1, (numberY + 2)] = bronza;
                        massPole[0, (numberY + 2)] = bronza;

                    }
                }

                else
                {
                    if (numberY == 0)
                    {
                        //serebro
                        massPole[(numberX + 1), visota] = serebro;
                        massPole[numberX, visota] = serebro;
                        massPole[(numberX - 1), visota] = serebro;

                        //bronza
                        massPole[(numberX + 2), visota] = bronza;
                        massPole[(numberX + 2), (visota - 1)] = bronza;
                        massPole[(numberX + 1), (visota - 1)] = bronza;
                        massPole[numberX, (visota - 1)] = bronza;
                        massPole[(numberX - 1), (visota - 1)] = bronza;
                        massPole[(numberX - 2), (visota - 1)] = bronza;
                        massPole[(numberX - 2), visota] = bronza;

                    }
                    else if (numberY == 1)
                    {
                        //bronza
                        massPole[(numberX - 2), visota] = bronza;
                        massPole[(numberX - 1), visota] = bronza;
                        massPole[numberX, visota] = bronza;
                        massPole[(numberX + 1), visota] = bronza;
                        massPole[(numberX + 2), visota] = bronza;

                    }
                    else if (numberY == (visota - 1))
                    {
                        //bronza
                        massPole[(numberX - 2), 0] = bronza;
                        massPole[(numberX - 1), 0] = bronza;
                        massPole[numberX, 0] = bronza;
                        massPole[(numberX + 1), 0] = bronza;
                        massPole[(numberX + 2), 0] = bronza;
                    }
                    else if (numberY == visota)
                    {
                        //serebro
                        massPole[(numberX + 1), 0] = serebro;
                        massPole[numberX, 0] = serebro;
                        massPole[(numberX - 1), 0] = serebro;

                        //bronza
                        massPole[(numberX + 2), 0] = bronza;
                        massPole[(numberX + 2), 1] = bronza;
                        massPole[(numberX + 1), 1] = bronza;
                        massPole[numberX, 1] = bronza;
                        massPole[(numberX - 1), 1] = bronza;
                        massPole[(numberX - 2), 1] = bronza;
                        massPole[(numberX - 2), 0] = bronza;

                    }
                }
            }
            return massPole;
        }
    }
}
