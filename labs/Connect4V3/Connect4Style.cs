using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Connect4V3
{
    class Connect4Style : ChangeNotification
    {
        readonly ICommand startGame;
        readonly ICommand playChips;
        GameBoard gameBoard;
        ObservableCollection<string> boardLocationColors;
        string burlyPlayerWins;
        string grayPlayerWins;
        string isBoardEnabled;

        public Connect4Style()
        { 
            startGame = new Command(this.InitializeGame);
            playChips = new Command(this.PlayChip);
            InitializeGame();
        }

        public static bool CanIncreaseBurlyScore = false;
        public static bool CanIncreaseGrayScore = false;

        string ConvertChipColor(Chips chips)
        {
            if (chips == Chips.Burlywood)
            {
                return "Burlywood";
            }
            if (chips == Chips.Gray)
            {
                return "Gray";
            }
            return "AliceBlue";
        }

        public void InitializeGame()
        {
            gameBoard = new GameBoard();
            gameBoard.Initialize();
            BoardLocationColors = new ObservableCollection<string>
              (Enumerable.Repeat<string>("AliceBlue", GameBoard.MaxRow * GameBoard.MaxColumn));
            //BurlyPlayersTurn = "Visible";
            //GrayPlayersTurn = "Hidden";
            BurlyPlayerWins = "Hidden";
            GrayPlayerWins = "Hidden";
            CurrentPlayerChip = Chips.Burlywood;
            IsBoardEnabled = "True";
            CanIncreaseBurlyScore = false;
            CanIncreaseGrayScore = false;
    }

        public ICommand StartGame { get { return startGame; } }
        public ICommand PlayChips { get { return playChips; } }

        public ObservableCollection<string> BoardLocationColors
        {
            get { return boardLocationColors; }
            private set
            {
                boardLocationColors = value;
                FirePropertyChanged("BoardLocationColors");
            }
        }

        /*public string BurlyPlayersTurn
        {
            get { return burlyPlayersTurn; }
            private set
            {
                burlyPlayersTurn = value;
                FirePropertyChanged("BurlyPlayersTurn");
            }
        }

        public string GrayPlayersTurn
        {
            get { return grayPlayersTurn; }
            private set
            {
                grayPlayersTurn = value;
                FirePropertyChanged("GrayPlayersTurn");
            }
        }*/

        public string BurlyPlayerWins
        {
            get { return burlyPlayerWins; }
            private set
            {
                burlyPlayerWins = value;
                FirePropertyChanged("BurlyPlayerWins");
            }
        }

        public string GrayPlayerWins
        {
            get { return grayPlayerWins; }
            private set
            {
                grayPlayerWins = value;
                FirePropertyChanged("GrayPlayerWins");
            }
        }

        public string IsBoardEnabled
        {
            get { return isBoardEnabled; }
            private set
            {
                isBoardEnabled = value;
                FirePropertyChanged("IsBoardEnabled");
            }
        }

        void DeclareWinner(Chips chips)
        {
            if(CurrentPlayerChip == Chips.Burlywood)
            {
                CanIncreaseBurlyScore = true;
            }
            if(CurrentPlayerChip == Chips.Gray)
            {
                CanIncreaseGrayScore = true;
            }           
            BurlyPlayerWins = chips == Chips.Burlywood ? "Visible" : "Hidden";
            GrayPlayerWins = chips == Chips.Gray ? "Visible" : "Hidden";
            IsBoardEnabled = "False";
        }

        void SwitchTurn(Chips chips)
        {
            CurrentPlayerChip = chips == Chips.Burlywood ? Chips.Gray : Chips.Burlywood;
        }

        Chips CurrentPlayerChip { get; set; }

        void PlayChip(object column)
        {
            //gameboard columns are not zero based
            var chipWasPlaced = gameBoard.PlayChips(CurrentPlayerChip, (int)column + 1);
            if (chipWasPlaced)
            {
                var index = gameBoard.LastPositionPlayedOrdered();
                boardLocationColors[index] = ConvertChipColor(CurrentPlayerChip);
                if (!gameBoard.Winner())
                {
                    SwitchTurn(CurrentPlayerChip);
                }
                else
                {
                    DeclareWinner(CurrentPlayerChip);
                }
            }
        }       
    }
}
