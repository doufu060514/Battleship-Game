using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MVC_Battleship
{
    public class Board
    {
        private int[,] boardPlayer = new int[10, 10];
        private int[,] boardAI = new int[10, 10];
        
        //Get boardPlayer
        public int[,] getBoardPlayer()
        {
            return boardPlayer;
        }

        //Set boardPlayer
        public void setBoardPlayer(int[,] boards)
        {
            boardPlayer = boards;
        }

        //Get boardAI
        public int[,] getBoardAI()
        {
            return boardAI;
        }

        //setBoardAI
        public void setBoardAI(int[,] boards)
        {
            boardAI = boards;
        }

        //Save the boards by serialization
        public void saveGame()
        {
            int[] bPlayer = new int[100];
            int[] bAI = new int[100];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    bPlayer[i * 10 + j] = boardPlayer[i, j];
                    bAI[i * 10 + j] = boardAI[i, j];
                }
            }
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(int[]));

            var path = System.Environment.CurrentDirectory + "//SerializationPlayerBoard.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            //Save the player game board to SerilizaitonPlayerBoard.xml
            writer.Serialize(file, bPlayer);
            file.Close();

            path = System.Environment.CurrentDirectory + "//SerializationAIBoard.xml";
            file = System.IO.File.Create(path);
            //Save the AI game board to SerilizaitonAIBoard.xml
            writer.Serialize(file, bAI);
            file.Close();
            MessageBox.Show("Save Game Successfully", "Success");
        }

        //Load the game from save file
        public Boolean loadGame()
        {
            Boolean fileExist = true;
            int[] bPlayer = new int[100];
            int[] bAI = new int[100];
            try {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(int[]));
                System.IO.StreamReader file = new System.IO.StreamReader(
                     System.Environment.CurrentDirectory + "//SerializationPlayerBoard.xml");
                bPlayer = (int[])reader.Deserialize(file);
                file.Close();
                file = new System.IO.StreamReader(
                     System.Environment.CurrentDirectory + "//SerializationAIBoard.xml");
                bAI = (int[])reader.Deserialize(file);
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        boardPlayer[i, j] = bPlayer[i * 10 + j];
                        boardAI[i, j] = bAI[i * 10 + j];
                    }
                }
            }
            catch (Exception e)
            {
                fileExist = false;
                MessageBox.Show("Can't find a save file.", "Error");
            }
            
            return fileExist;
        }

        //Reset the game board for player and AI
        public void resetBoards()
        {
            boardPlayer = new int[10, 10];
            boardAI = new int[10, 10];
        }
    }
}
