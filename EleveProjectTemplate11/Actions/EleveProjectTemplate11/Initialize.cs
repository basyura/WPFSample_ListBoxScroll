using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Eleve;
using EleveProjectTemplate11.Models;

namespace EleveProjectTemplate11.Actions.EleveProjectTemplate11
{
    public class Initialize : EleveProjectTemplate11ActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object parameter)
        {
            for (int i = 0; i < 10000; i++)
            {
                ViewModel.Originals.Add(new Item() { Name = i.ToString() });
            }

            return SuccessTask;
        }
    }
}
