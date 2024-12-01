namespace G24W1402WPFDialog;

//public class GundamModel {
//    public string Name { get; set; }
//    public string Model { get; set; }
//    public string Party { get; set; }
//}

public class GundamModel {
    //public GundamModel(string name, string model, string party) {
    //    Name = name;
    //    Model = model;
    //    Party = party;
    //}

    // Lambda expression 사용
    // (name, model, party): Tuple 생성
    // Destructuring을 사용하여 각각 Name, Model, Party에 할당
    public GundamModel(string name, string model, string party) =>
        (Name, Model, Party) = (name, model, party);

    // 읽기 전용이므로 생성자에서만 초기화 가능
    public string Name { get; }
    public string Model { get; }
    public string Party { get; }
}
