using System;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ScapeRoomProject
{
    public sealed class Session
    {
        private static volatile Session instance;
        private static object sync = new Object();

        private Session()
        { }

        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                        {
                            instance = new Session();
                        }
                    }
                }
                return instance;
            }
        }

        public String getSenha(int modulo)
        {
            switch (modulo)
            {
                case 1:
                    return "senha1";
                case 2:
                    return "senha2";
                case 3:
                    return "senha3";
                case 4:
                    return "senha4";
                case 5:
                    return "senha5";
                case 6:
                    return "senha6";
                case 7:
                    return "senha7";
                case 8:
                    return "senha8";
                case 9:
                    return "senha9";
                case 10:
                    return "senha10";
                case 11:
                    return "senha11";
                case 12:
                    return "senha12";
                default:
                    return "";
            }
        }

        public String getResposta(int modulo)
        {
            switch (modulo)
            {
                case 1:
                    return "resposta1";
                case 2:
                    return "resposta2";
                case 3:
                    return "resposta3";
                case 4:
                    return "resposta4";
                case 5:
                    return "resposta5";
                case 6:
                    return "resposta6";
                case 7:
                    return "resposta7";
                case 8:
                    return "resposta8";
                case 9:
                    return "resposta9";
                case 10:
                    return "resposta10";
                case 11:
                    return "resposta11";
                case 12:
                    return "resposta12";
                default:
                    return "";
            }
        }
    }
}

