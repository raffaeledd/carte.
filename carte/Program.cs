class Test
{
    enum semi
    {
        coppe = 0,
        denari = 1,
        bastoni = 2,
        spade = 3,
    }

    static void Main()
    {
        int giocatorevincente = 1;
        int puntigiocatore1 = 0;
        int puntigiocatore2 = 0;

        int numbriscola;
        semi semebriscola;

        Console.WriteLine("inserisci il numero ed il seme della briscola:");
        Console.WriteLine("1-10");
        numbriscola = int.Parse(Console.ReadLine());
        Console.WriteLine("coppe/denari/bastoni/spade");
        semebriscola = Enum.Parse<semi>(Console.ReadLine(), ignoreCase: true);

        for (int i = 0; i < 20; i++)
        {

            int numgiocata1;
            semi semegiocata1;
            int numgiocata2;
            semi semegiocata2;

            Console.Write("inserisci il numero ed il seme della giocata del ");
            if (giocatorevincente == 1)
            {
                Console.WriteLine("giocatore 1:");
                
            }
            else
            {
                Console.WriteLine("giocatore 2:");
                
            }

            Console.WriteLine("1-10");
            numgiocata1 = int.Parse(Console.ReadLine());
            switch (numgiocata1)
            {
                case 1:
                    numgiocata1 = 12;
                    break;
                case 3:
                    numgiocata1 = 11;
                    break;
            }

            Console.WriteLine("coppe/denari/bastoni/spade");
            semegiocata1 = Enum.Parse<semi>(Console.ReadLine(), ignoreCase: true);

            Console.Write("inserisci il numero ed il seme della giocata del ");
            if (giocatorevincente == 2)
            {
                Console.WriteLine("giocatore 1:");
            }
            else
            {
                Console.WriteLine("giocatore 2:");
            }

            Console.WriteLine("1-10");
            numgiocata2 = int.Parse(Console.ReadLine());
            switch (numgiocata2)
            {
                case 1:
                    numgiocata2 = 12;
                    break;
                case 3:
                    numgiocata2 = 11;
                    break;
            }

            Console.WriteLine("coppe/denari/bastoni/spade");
            semegiocata2 = Enum.Parse<semi>(Console.ReadLine(), ignoreCase: true);


            if (semegiocata2 == semegiocata1)
            {
                if (numgiocata2 > numgiocata1)
                {
                    if (giocatorevincente == 1)
                    {
                        switch (numgiocata1)
                        {
                            case 8:
                                puntigiocatore2 += 2;
                                break;
                            case 9:
                                puntigiocatore2 += 3;
                                break;
                            case 10:
                                puntigiocatore2 += 4;
                                break;
                            case 1:
                                puntigiocatore2 += 11;
                                break;
                            case 3:
                                puntigiocatore2 += 10;
                                break;
                        }

                        switch (numgiocata2)
                        {

                            case 8:
                                puntigiocatore2 += 2;
                                break;
                            case 9:
                                puntigiocatore2 += 3;
                                break;
                            case 10:
                                puntigiocatore2 += 4;
                                break;
                            case 1:
                                puntigiocatore2 += 11;
                                break;
                            case 3:
                                puntigiocatore2 += 10;
                                break;
                        }

                        Console.WriteLine("il giocatore 2 ha vinto il turno");
                        giocatorevincente = 2;
                    }
                    else
                    {
                        switch (numgiocata1)
                        {
                            case 8:
                                puntigiocatore1 += 2;
                                break;
                            case 9:
                                puntigiocatore1 += 3;
                                break;
                            case 10:
                                puntigiocatore1 += 4;
                                break;
                            case 1:
                                puntigiocatore1 += 11;
                                break;
                            case 3:
                                puntigiocatore1 += 10;
                                break;
                        }

                        switch (numgiocata2)
                        {

                            case 8:
                                puntigiocatore1 += 2;
                                break;
                            case 9:
                                puntigiocatore1 += 3;
                                break;
                            case 10:
                                puntigiocatore1 += 4;
                                break;
                            case 1:
                                puntigiocatore1 += 11;
                                break;
                            case 3:
                                puntigiocatore1 += 10;
                                break;
                        }

                        Console.WriteLine("il giocatore 1 ha vinto il turno");
                        giocatorevincente = 1;
                    }
                }
                else
                {
                    switch (numgiocata1)
                    {
                        case 8:
                            puntigiocatore1 += 2;
                            break;
                        case 9:
                            puntigiocatore1 += 3;
                            break;
                        case 10:
                            puntigiocatore1 += 4;
                            break;
                        case 1:
                            puntigiocatore1 += 11;
                            break;
                        case 3:
                            puntigiocatore1 += 10;
                            break;
                    }

                    switch (numgiocata2)
                    {
                        case 8:
                            puntigiocatore1 += 2;
                            break;
                        case 9:
                            puntigiocatore1 += 3;
                            break;
                        case 10:
                            puntigiocatore1 += 4;
                            break;
                        case 1:
                            puntigiocatore1 += 11;
                            break;
                        case 3:
                            puntigiocatore1 += 10;
                            break;
                    }

                    Console.WriteLine("il giocatore 1 ha vinto il turno");
                    giocatorevincente = 1;
                }
            }
            else if (semegiocata2 == semebriscola)
            {
                if (giocatorevincente == 1)
                {
                    switch (numgiocata1)
                    {
                        case 8:
                            puntigiocatore2 += 2;
                            break;
                        case 9:
                            puntigiocatore2 += 3;
                            break;
                        case 10:
                            puntigiocatore2 += 4;
                            break;
                        case 1:
                            puntigiocatore2 += 11;
                            break;
                        case 3:
                            puntigiocatore2 += 10;
                            break;
                    }

                    switch (numgiocata2)
                    {

                        case 8:
                            puntigiocatore2 += 2;
                            break;
                        case 9:
                            puntigiocatore2 += 3;
                            break;
                        case 10:
                            puntigiocatore2 += 4;
                            break;
                        case 1:
                            puntigiocatore2 += 11;
                            break;
                        case 3:
                            puntigiocatore2 += 10;
                            break;
                    }

                    Console.WriteLine("il giocatore 2 ha vinto il turno");
                    giocatorevincente = 2;
                }
                else
                {
                    switch (numgiocata1)
                    {
                        case 8:
                            puntigiocatore1 += 2;
                            break;
                        case 9:
                            puntigiocatore1 += 3;
                            break;
                        case 10:
                            puntigiocatore1 += 4;
                            break;
                        case 1:
                            puntigiocatore1 += 11;
                            break;
                        case 3:
                            puntigiocatore1 += 10;
                            break;
                    }

                    switch (numgiocata2)
                    {

                        case 8:
                            puntigiocatore1 += 2;
                            break;
                        case 9:
                            puntigiocatore1 += 3;
                            break;
                        case 10:
                            puntigiocatore1 += 4;
                            break;
                        case 1:
                            puntigiocatore1 += 11;
                            break;
                        case 3:
                            puntigiocatore1 += 10;
                            break;
                    }

                    Console.WriteLine("il giocatore 1 ha vinto il turno");
                    giocatorevincente = 1;
                }
            }
            else
            {
                if (giocatorevincente == 2)
                {
                    switch (numgiocata1)
                    {
                        case 8:
                            puntigiocatore2 += 2;
                            break;
                        case 9:
                            puntigiocatore2 += 3;
                            break;
                        case 10:
                            puntigiocatore2 += 4;
                            break;
                        case 1:
                            puntigiocatore2 += 11;
                            break;
                        case 3:
                            puntigiocatore2 += 10;
                            break;
                    }

                    switch (numgiocata2)
                    {

                        case 8:
                            puntigiocatore2 += 2;
                            break;
                        case 9:
                            puntigiocatore2 += 3;
                            break;
                        case 10:
                            puntigiocatore2 += 4;
                            break;
                        case 1:
                            puntigiocatore2 += 11;
                            break;
                        case 3:
                            puntigiocatore2 += 10;
                            break;
                    }

                    Console.WriteLine("il giocatore 2 ha vinto il turno");
                    giocatorevincente = 2;
                }
                else
                {
                    switch (numgiocata1)
                    {
                        case 8:
                            puntigiocatore1 += 2;
                            break;
                        case 9:
                            puntigiocatore1 += 3;
                            break;
                        case 10:
                            puntigiocatore1 += 4;
                            break;
                        case 1:
                            puntigiocatore1 += 11;
                            break;
                        case 3:
                            puntigiocatore1 += 10;
                            break;
                        }

                    switch (numgiocata2)
                    {

                        case 8:
                            puntigiocatore1 += 2;
                            break;
                        case 9:
                            puntigiocatore1 += 3;
                            break;
                        case 10:
                            puntigiocatore1 += 4;
                            break;
                        case 1:
                            puntigiocatore1 += 11;
                            break;
                        case 3: 
                            puntigiocatore1 += 10; break;
                    }

                        Console.WriteLine("il giocatore 1 ha vinto il turno");
                        giocatorevincente = 1;
                }
            }
        }

        if (puntigiocatore2 < puntigiocatore1)
        {
                Console.WriteLine("il giocatore 1 ha vinto");
        }
        else
        {
                Console.WriteLine("il giocatore 2 ha vinto");
        }
    }
}