using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViRGO.Net.Cad.Lib
{
    public class UserGet
    {
        public static Point3d Get_Point(string ThongBao, Point3d Pgiong)
        {
            Point3d P3D = new Point3d();
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            PromptPointOptions acPtOpt = new PromptPointOptions("");
            PromptPointResult acPtRes;
            acPtOpt.Message = ThongBao;
            if (Pgiong != new Point3d())
            {
                acPtOpt.BasePoint = Pgiong;
                acPtOpt.UseBasePoint = true;
            }
            acPtRes = ed.GetPoint(acPtOpt);
            if (acPtRes.Status == PromptStatus.OK) P3D = acPtRes.Value;
            return P3D;
        }

        public static SelectionSet Get_SSget(Transaction trans, string ThongBao, SelectionFilter Loc)
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            PromptSelectionOptions Select = new PromptSelectionOptions
            {
                MessageForAdding = ThongBao
            };
            PromptSelectionResult Select_Res = ed.GetSelection(Select, Loc);
            if (Select_Res.Status == PromptStatus.Error)
            {
                SelectionSet ss = null;
                return ss;
            }
            return Select_Res.Value;
        }






    }
}
