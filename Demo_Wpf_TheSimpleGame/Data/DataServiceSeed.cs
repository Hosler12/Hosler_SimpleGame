using Demo_Wpf_TheSimpleGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_TheSimpleGame.Data
{
    public class DataServiceSeed : IDataService
    {
        public List<Player> ReadAll()
        {
            return new List<Player>()
            {
                new Player()
                {
                    Name = "Darth",
                    Wins = 0,
                    Losses = 0,
                    Ties = 0
                },

                new Player()
                {
                    Name = "Leia",
                    Wins = 0,
                    Losses = 0,
                    Ties = 0
                }
            };
        }

        public void WriteAll(List<Player> players)
            {
                // method stub to keep the interface implementation happy
            }
        }
    }
