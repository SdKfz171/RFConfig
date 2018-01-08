using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFConfig.Controllers
{
    public class PageIndex
    {

        public int _Page;

        public int Page
        {
            get
            {
                return _Page;
            }
            set
            {
                _Page = value;
                OnPageChanged();
            }
        }
        //public static int Page { get; set; }

        public event EventHandler PageChanged;

        protected virtual void OnPageChanged()
        {
            if (PageChanged != null) PageChanged(this, EventArgs.Empty);

            Debug.WriteLine("페이지 바뀜!");
        }
    }
}
