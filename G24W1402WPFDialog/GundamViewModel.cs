using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace G24W1402WPFDialog;

public class GundamViewModel : INotifyPropertyChanged {
    //private string _GundamList = "";
    //public string GundamList => _GundamList;

    private ObservableCollection<string> _gundamList = new ObservableCollection<string>();
    //public ObservableCollection<string> GundamList => _gundamList;

    public string GundamListString => string.Join("\n", _gundamList);

    public void Add(GundamModel model) {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("{0}의 {1} {2}{3} 추가되었습니다.",
            model.Party,
            model.Model,
            model.Name,
            HasJongsung(model.Name) ? "이" : "가");

        //_gundamList.Add(sb.ToString());
        _gundamList.Insert(0, sb.ToString());

        // 실제로는 _gundamList를 변경하지만,
        // GundamListString이 변경되었다고 알려서 Binding 동작
        OnPropertyChanged(nameof(GundamListString));
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }

    protected bool HasJongsung(string str) {
        if (str.Length < 1)
            return true;

        char last = str[str.Length - 1];
        return (last - 44032) % 28 != 0;
    }
}