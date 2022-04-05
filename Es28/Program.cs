using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Es28_prova
{
    class Program
    {
        /*Sviluppare la classe AlberoBinarioIntero con i attributi 
        int val,  
        AlberoBinarioIntero  sx,  
        AlberoBinarioIntero  dx.

        Notare che gli attributi dx e sx sono anch'essi del tipo AlberoBinarioIntero perchè sono anch'essi degli alberi binari essendo l'albero una struttura ricorsiva.
        Aggiungere i metodi di inserimento di figlio dx e figlio sx per agganciare un albero binario a destra o a sinistra

        Provare a creare con questi metodi l'albero binario nell'immagine a questo link:
        https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTJQuXa37eEBJJRrk7ft-ANd0EvdbbjP1pA8g&usqp=CAU*/

        static void Main(string[] args)
        {
            AlberoBinario sx;
            AlberoBinario dx;
            AlberoBinario p;
            AlberoBinario r = new AlberoBinario(69);

            sx = new AlberoBinario(2);
            dx = new AlberoBinario(71);
            p = new AlberoBinario(39, sx, dx);
            sx = p;
            dx = new AlberoBinario(66);

            r.aggiungiFiglioSx(new AlberoBinario(89,sx, dx));

            sx = new AlberoBinario(44);
            dx = new AlberoBinario(12);

            r.aggiungiFiglioDx(new AlberoBinario(28,sx, dx));

            r.stampa();

            Console.WriteLine("........................");
            Console.WriteLine(r);

            Console.ReadKey();
        }
        class AlberoBinario
        {
            int val;
            AlberoBinario dx;
            AlberoBinario sx;
            
            public AlberoBinario(int val,AlberoBinario sx, AlberoBinario dx)
            {
                this.val=val;
                this.dx=dx;
                this.sx=sx;
            }
            public AlberoBinario(int val)
            {
                this.val = val;
                this.dx = null;
                this.sx = null;
            }
            public void aggiungiFiglioSx(AlberoBinario n)
            {
                this.sx = n;
            }
            public void aggiungiFiglioDx(AlberoBinario n)
            {
                this.dx = n;
            }
            public override string ToString()
            {
                string str = null;


                if (dx == null && sx == null)
                {
                    str += this.val;
                }
                else
                {
                    str += this.val;

                    try
                    {
                        str+=sx.ToString();
                    }
                    catch
                    {
                       
                    }

                    try
                    {
                        str+=dx.ToString();
                    }
                    catch
                    {
                        
                    }
                }
                return "(" + str + ")";
            }
            public void stampa()
            {
                if(sx==null&& dx == null)
                {
                    Console.WriteLine(this.val);
                }
                else
                {
                    Console.WriteLine(this.val);

                    try
                    {
                        sx.stampa();
                    }
                    catch
                    {
                        Console.WriteLine("Sin");
                    }
                    try
                    {
                        dx.stampa();
                    }
                    catch
                    {
                        Console.WriteLine("Des");
                    }
                    
                }
            }
            public void stampaIterativa()
            {
                Stack s = new Stack();
                s.Push(this);
                while (s.Count != 0)
                {
                    AlberoBinario tmp = s.Pop() as AlberoBinario;
                    Console.WriteLine(tmp.val);

                    if (tmp.dx != null)
                    {
                        s.Push(tmp.dx);
                    }
                    if (tmp.sx != null)
                    {
                        s.Push(tmp.sx);
                    }
                }
            }

        }

    }
}