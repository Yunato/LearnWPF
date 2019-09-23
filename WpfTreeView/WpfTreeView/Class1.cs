//using PropertyChanged;
//using System.ComponentModel;

//namespace WpfTreeView
//{
//    [ImplementPropertyChanged]
//    public class Class1 : INotifyPropertyChanged
//    {
//        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

//        public string Test { get; set; }
//        //public string Test
//        //{
//        //    get 
//        //    {
//        //        return mTest;
//        //    }
//        //    set 
//        //    {
//        //        if (mTest == value)
//        //            return;

//        //        mTest = value;
//        //         ハードコーディングでは"名前の変更"でプロパティ名」を変更したとき、同時に変更されないため nameof() を呼ぶ
//        //        PropertyChanged(this, new PropertyChangedEventArgs(nameof(Test)));
//        //    }
//        //}

//        //public Class1()
//        //{
//        //    Task.Run(async () =>
//        //    {
//        //        int i = 0;

//        //        while (true)
//        //        {
//        //            await Task.Delay(200);
//        //            Test = (i++).ToString();

//        //        }
//        //    });
//        //}
//    }
//}
