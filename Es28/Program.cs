using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            AlberoBinario a = new AlberoBinario();
            a.insDX(69);
            a.insDX(23);
            a.insSX(33);
        }
        class AlberoBinario
        {
            AlberoBinario radice;
            AlberoBinario dx;
            AlberoBinario sx;
            
            int val;
            private AlberoBinario succDx;
            private AlberoBinario succSx;

            public AlberoBinario(int n)
            {
                radice.val= n;
            }
            public AlberoBinario() { }

            public void insDX(int val)
            {
                AlberoBinario n = new AlberoBinario(val);
                if (radice == null)
                {
                    radice = n;
                }
                else
                {
                    n.setSuccDx(radice);
                    radice = n;
                }
            }
            public void insSX(int val)
            {
                AlberoBinario n = new AlberoBinario(val);
                if (radice == null)
                {
                    radice = n;
                }
                else
                {
                    n.setSuccSx(radice);
                    radice = n;
                }
            }
            public void setSuccDx(AlberoBinario n)
            {
                this.succDx = n;
            }

            public void setSuccSx(AlberoBinario n)
            {
                this.succSx = n;
            }

            public int getVal()
            {
                return val;
            }

            public void setVal(int val)
            {
                this.val = val;
            }
        }

    }
}