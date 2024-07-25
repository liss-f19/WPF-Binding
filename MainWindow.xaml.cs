using System;
using System.Collections.Generic;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Bflix
{
    public partial class MainWindow : Window
    {
        public List<Film> Films { get; set; }
        

        public MainWindow()
        {
            InitializeComponent();

            Films = new List<Film>()
            {
                new Film()
                {
                    Title = "Rubber",
                    AudienceScore = 6,
                    BigImageURI = "Images/rubber_big.png",
                    SmallImageURI = "Images/rubber_small.jpg",
                    Description = "Careful where you tread",
                    People = new List<Tuple<string, string>>()
                    {
                        new Tuple<string, string>("Director", "Quentin Dupieux"),
                        new Tuple<string, string>("Actor", "Stephen Spinella"),
                        new Tuple<string, string>("Actor", "Roxane Mesquida"),
                        new Tuple<string, string>("Actor", "Wings Hauser"),
                    },
                    Reviews = new List<Review>()
                    {
                        new Review()
                        {
                            ImageURI = "Images/ReviewerA.png",
                            Text = "What an esoteric experience!",
                            Author = "Ben",
                        },
                        new Review()
                        {
                            ImageURI = "Images/ReviewerB.jpg",
                            Text = "Not worth your time.",
                            Author = "California123",
                        },
                        new Review()
                        {
                            ImageURI = "Images/ReviewerC.jpg",
                            Text = "Too long, didn't watch",
                            Author = "RedCauliflower",
                        },
                        new Review()
                        {
                            ImageURI = "Images/ReviewerA.png",
                            Text = "Psychic murderous rubber!",
                            Author = "Cinema enjoyer",
                        }
                    }
                },
                new Film()
                {
                    Title = "Dracula 2000",
                    AudienceScore = 5,
                    BigImageURI = "Images/dracula_big.png",
                    SmallImageURI = "Images/dracula_big.png",
                    Description = "A group of thieves breaks into a chamber expecting to find paintings, but instead they release the count himself, who travels to New Orleans to find his nemesis' daughter, Mary Van Helsing.",
                    People = new List<Tuple<string, string>>()
                    {
                        new Tuple<string, string>("Director","Patrick Lussier"),
                        new Tuple<string, string>("Actor","Gerard Butler"),
                        new Tuple<string, string>("Actor","Justine Waddell"),
                        new Tuple<string, string>("Actor","Jonny Lee Miller"),
                    },
                    Reviews = new List<Review>()
                    {
                        new Review()
                        {
                            ImageURI = "Images/ReviewerE.jpg",
                            Text = "Dracula, Dracula, Dracula!",
                            Author = "VanHelsing",
                        },
                        new Review()
                        {
                            ImageURI = "Images/ReviewerF.jpg",
                            Text = "Who the hell is Van Helsing???",
                            Author = "Dracula",
                        },
                        new Review()
                        {
                            ImageURI = "Images/ReviewerG.png",
                            Text = "What an utter mess!",
                            Author = "Amy Smith",
                        },
                        new Review()
                        {
                            ImageURI = "Images/ReviewerA.png",
                            Text = "So bad, that you just have to watch to the end!!!",
                            Author = "Dormamu12q41",
                        }
                    }
                },
                new Film()
                {
                    Title = "Robin Hood: Men in tights",
                    AudienceScore = 5,
                    BigImageURI = "Images/robin_big.png",
                    SmallImageURI = "Images/robin_small.png",
                    Description = "I lost. I lost? Wait a second, I'm not supposed to lose. Let me see the script.",
                    People = new List<Tuple<string, string>>()
                    {
                        new Tuple<string, string>("Director","Mel Brooks"),
                        new Tuple<string, string>("Actor","Cary Elwes"),
                        new Tuple<string, string>("Actor","Richard Lewis"),
                        new Tuple<string, string>("Actor","Roger Rees"),
                    },
                    Reviews = new List<Review>()
                    {
                        new Review()
                        {
                            ImageURI = "Images/Shepard.jpg",
                            Text = "I'm commander Shepard, and this is my favourite film on Bflix!",
                            Author = "ReapersDestroyer10",
                        },
                        new Review()
                        {
                            ImageURI = "Images/Robin.jpg",
                            Text = "So that is the real story...",
                            Author = "NothingamDweller",
                        },
                        new Review()
                        {
                            ImageURI = "Images/Gandalf.jpg",
                            Text = "Why didn't they use eagles???",
                            Author = "Gandalf12345",
                        },
                        new Review()
                        {
                            ImageURI = "Images/Ridley.jpg",
                            Text = "Beautifully done!",
                            Author = "RealDirector",
                        }
                    }
                },
                new Film()
                {
                    Title = "Sharknado 3: Oh Hell No!",
                    AudienceScore = 3,
                    BigImageURI = "Images/sharknado3_big.png",
                    SmallImageURI = "Images/sharknado3_small.png",
                    Description = "Sharks in space!!!",
                    People = new List<Tuple<string, string>>()
                    {
                        new Tuple<string, string>("Director","Anthony C. Ferrante"),
                        new Tuple<string, string>("Actor","Ian Ziering"),
                        new Tuple<string, string>("Actor","Tara Reid"),
                        new Tuple<string, string>("Actor","Cassandra Scerbo"),
                    },
                    Reviews = new List<Review>()
                    {
                        new Review()
                        {
                            ImageURI = "Images/Consul.jpg",
                            Text = "In Spaaaaaaaaace!",
                            Author = "Consul",
                        },
                        new Review()
                        {
                            ImageURI = "Images/ReviewerB.jpg",
                            Text = "W H A T?",
                            Author = "John Doe",
                        },
                        new Review()
                        {
                            ImageURI = "Images/ReviewerE.jpg",
                            Text = "You must watch it at least once",
                            Author = "Best worst films",
                        },
                        new Review()
                        {
                            ImageURI = "Images/Kenobi.jpg",
                            Text = "Hello there!",
                            Author = "Obi-Wan Kenobi",
                        }
                    }
                },
                new Film()
                {
                    Title = "The Room",
                    AudienceScore = 3,
                    BigImageURI = "Images/the_room_big.png",
                    SmallImageURI = "Images/the_room_small.png",
                    Description = "The one and only!",
                    People = new List<Tuple<string, string>>()
                    {
                        new Tuple<string, string>("Director","Tommy Wiseau"),
                        new Tuple<string, string>("Actor","Tommy Wiseau"),
                        new Tuple<string, string>("Actor","Juliette Danielle"),
                        new Tuple<string, string>("Actor","Greg Sestero"),
                    },
                    Reviews = new List<Review>()
                    {
                        new Review()
                        {
                            ImageURI = "Images/Palpatine.jpg",
                            Text = "I'm the Senate!",
                            Author = "Emperor Palpatine",
                        },
                        new Review()
                        {
                            ImageURI = "Images/Windu.jpg",
                            Text = "Not yet!",
                            Author = "Mace Windu",
                        },
                        new Review()
                        {
                            ImageURI = "Images/ReviewerA.png",
                            Text = "What is this comment section...",
                            Author = "Concerned User",
                        },
                        new Review()
                        {
                            ImageURI = "Images/Palpatine.jpg",
                            Text = "Unlimited Power!!!!",
                            Author = "Emperor P@lpatine",
                        }
                    }
                }
            };

            DataContext = Films;
        }



    }
}
