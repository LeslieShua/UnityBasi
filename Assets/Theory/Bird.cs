public class Bird {
    //기본값이 private이라 public으로 해준다음 가져다 쓸 수 있음 함수도 마찬가지
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Fly() {
        return "날다";
    }

    public string HasWeapon() {
        return weapon;
    }

    public void LevelUp() {
        level = level + 1;
    }
}
