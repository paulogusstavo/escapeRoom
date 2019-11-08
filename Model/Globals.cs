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
                case 1: //FACIL
                    return "c";
                case 2: //MEDIO
                    return "~qvs";
                case 3: //MEDIO
                    return "~pvqvs";
                case 4: // FACIL
                    return "p^q";
                case 5: // DIFICIL
                    return "(pv~qvr)^(~pvq)";
                case 6: // DIFICIL
                    return "~p";
                case 7: //DIFICIL
                    return "pv~qvr";
                case 8: //MEDIO
                    return "qvs";
                case 9: //DIFICIL
                    return "f";
                case 10: //MEDIO
                    return "~pvq";
                case 11: //FACIL
                    return "p^~q";
                case 12: //SEQUESTRADOR
                    return "Bruno Campagnolo";
                default:
                    return "Erro";
            }
        }

        public String getResposta(int modulo)
        {
            switch (modulo)
            {
                case 1:
                    return "(Pista do Cativeiro) Dependência ampla e mais importante de uma habitação, destinada ao uso social."; 
                case 2:
                    return "(Pista do Sequestrador) A carreira de Kelly estava gerando inveja.";
                case 3:
                    return "11101010";
                case 4:
                    return "(Pista do Cativeiro) Obra ou forma em que uma das dimensões não predomina sobre as outras.";
                case 5: //SEM RESPOSTA
                    return "";
                case 6:
                    return "100011001";
                case 7:
                    return "(Pista do sequestrador) Compatriota.";
                case 8: //SEM RESPOSTA
                    return "";
                case 9:
                    return "(Pista do Cativeiro) Aquele que ensina, ministra aulas.";
                case 10: 
                    return "(Pista do Sequestrador) Indivíduo do sexo masculino.";
                case 11:
                    return "Pavimento o próprio solo.";
                case 12: // SEM RESPOSTA - SERA EXIBIDO ALERTA NA TELA.
                    return "";
                default:
                    return "";
            }
        }
    }
}

