using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Piece
    {
        public Piece(string piece, string composer, string key)
        {
            this.PieceName = piece;
            this.Composer = composer;
            this.Key = key;
        }
        public string PieceName { get; set; }

        public string Composer { get; set; }

        public string Key { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Piece> pieces = new List<Piece>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] currentSongDetails = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string piecesName = currentSongDetails[0];
                string composerName = currentSongDetails[1];
                string keyName = currentSongDetails[2];

                pieces.Add(new Piece(piecesName, composerName, keyName));

            }
            string actions = Console.ReadLine();
            while (actions != "Stop")
            {
                string[] actionArgs = actions.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string commType = actionArgs[0];
                if (commType == "Add")
                {
                    
                    string pieceName = actionArgs[1];
                    string composer = actionArgs[2];
                    string key = actionArgs[3];
                    AddPieceInList(pieces, pieceName, composer, key);
                }
                else if (commType == "Remove")
                {
                    string pieceName = actionArgs[1];
                    RemovePieceInList(pieces, pieceName);
                }
                else if (commType == "ChangeKey")
                {
                    string pieceName = actionArgs[1];
                    string newKey = actionArgs[2];
                    ChangeKeyInList(pieces, pieceName, newKey);
                }






                actions = Console.ReadLine();
            }

            foreach (var piece in pieces)
            {
                string pieceName = piece.PieceName;
                string composerName = piece.Composer;
                string key = piece.Key;

                Console.WriteLine($"{pieceName} -> Composer: {composerName}, Key: {key}");
            }
        }
        static void AddPieceInList(List<Piece> pieces, string pieceName, string composer, string key)
        {
            if (pieces.Exists(x => x.PieceName == pieceName))
            {
                Console.WriteLine($"{pieceName} is already in the collection!");
            }
            else
            {
                pieces.Add(new Piece(pieceName, composer, key));
                Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
            }
        }
        static void RemovePieceInList(List<Piece> pieces, string pieceName)
        {
            if (pieces.Exists(x => x.PieceName == pieceName))
            {
                int indexToRemove = pieces.FindIndex(x => x.PieceName == pieceName);
                pieces.RemoveAt(indexToRemove);
                Console.WriteLine($"Successfully removed {pieceName}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
            }
        }
        static void ChangeKeyInList(List<Piece> pieces, string pieceName, string key)
        {
            if (pieces.Exists(x => x.PieceName == pieceName))
            {
                int indexToChangeKey = pieces.FindIndex(x => x.PieceName == pieceName);
                pieces[indexToChangeKey].Key = key;
                Console.WriteLine($"Changed the key of {pieceName} to {key}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
            }
        }

    }


}
