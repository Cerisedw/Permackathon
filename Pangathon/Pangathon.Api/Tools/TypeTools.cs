using Pangathon.Api.Tools.Entities;
using Pangathon.DAL.Entities;
using System.Collections.Generic;

namespace Pangathon.Api.Tools
{
    public static class TypeTools
    {

        public static TypeView tToTV(TypeTache t)
        {
            TypeView tv = null;
            if (t.Parent != null)
            {
                tv = tToTV(t.Parent);
            }

            return new TypeView()
            {
                Nom = t.Nom,
                Parent = tv
            };
        }

        public static List<TypeView> listToListV(IEnumerable<TypeTache> ltt)
        {
            List<TypeView> listeTv = new List<TypeView>();
            foreach (TypeTache t in ltt)
            {
                listeTv.Add(tToTV(t));
            }
            return listeTv;
        }

    }
}
