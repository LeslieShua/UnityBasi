public class Bird {
    int id;
    string name;
    string title;
    string weapon;
    float strength;
    int level;

    string Fly() {
        return "날다";
    }

    string HasWeapon() {
        return weapon;
    }

    void LevelUp() {
        level = level + 1;
    }
}
