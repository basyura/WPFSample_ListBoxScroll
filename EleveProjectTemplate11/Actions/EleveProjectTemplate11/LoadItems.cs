using System;
using System.Threading.Tasks;
using Eleve;

namespace EleveProjectTemplate11.Actions.EleveProjectTemplate11
{
    public class LoadItems : EleveProjectTemplate11ActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object obj)
        {
            Task.Run(() =>
            {
                if (obj.ToString() == "Box1")
                {
                    ViewModel.Items1.Clear();
                    ViewModel.Originals.ForEach(v => ViewModel.Items1.Add(v));
                }
                else if (obj.ToString() == "Box2")
                {
                    ViewModel.Items2.Clear();
                    ViewModel.Originals.ForEach(v => ViewModel.Items2.Add(v));
                }
                else if (obj.ToString() == "Box3")
                {
                    ViewModel.Items3.Clear();
                    ViewModel.Originals.ForEach(v => ViewModel.Items3.Add(v));
                }
            });


            return SuccessTask;
        }
    }
}
