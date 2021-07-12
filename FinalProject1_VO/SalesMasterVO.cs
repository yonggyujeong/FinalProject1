﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class SalesMasterVO
    {
        public int PO_ID { get; set; }
        public string PO_WorkOrderID { get; set; } // Excel 선입력
        public string PO_PlanID { get; set; }
        public string PO_CompanyID { get; set; } // Excel 선입력
        public string PO_CompanyType { get; set; } // Excel 선입력
        public string PO_Destination { get; set; }
        public int PO_ItemID { get; set; } // Excel 선입력
        public int PO_OrderCnt { get; set; } // Excel 선입력
        public int PO_OutCnt { get; set; }
        public int PO_CancelCnt { get; set; }
        public string PO_DeadLine { get; set; } // Excel 선입력
        public string PO_UploadDate { get; set; }
        public string PO_EditManger { get; set; }
        public string PO_EditDate { get; set; }
        public string PO_Content { get; set; }

    }
}