Oyunun Temel Fikri
Flappy Bird mantığına dayalı bir 2D oyundur. Oyuncu karakteri boşluk tuşuyla yukarı zıplatarak borulardan geçmeye çalışır. Ekstra skor için aralarda beliren coinleri toplar. Her çarpışmada oyun biter ve en yüksek skor kaydedilir.
Coroutine Hangi Sistemde Kullanıldı?
PipeSpawner scriptinde boru ve coin üretimi için kullanıldı. SpawnRoutine adlı coroutine, PipeSettings'ten gelen spawnInterval değerine göre belirli aralıklarla boru spawn eder.
Object Pool Neden Tercih Edildi?
Borular sürekli ekrandan çıkıp yeniden oluşturulduğu için her seferinde Instantiate ve Destroy çağırmak performans açısından verimsizdir. PipePool sistemi ile borular önceden oluşturulur, ekrandan çıkınca yok edilmek yerine havuza geri döner ve tekrar kullanılır.
ScriptableObject Neyi Yönetmektedir?
PipeSettings adlı ScriptableObject şu verileri yönetir:

moveSpeed: Boru hareket hızı
spawnInterval: Borular arası süre
minHeight / maxHeight: Boruların çıkabileceği yükseklik aralığı

PlayerPrefs Hangi Veriyi Saklamaktadır?
ScoreManager içinde HighScore verisi PlayerPrefs ile saklanır. Oyun kapansa bile en yüksek skor korunur ve Game Over ekranında gösterilir.
