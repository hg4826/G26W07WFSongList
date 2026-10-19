using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace G26W07WFSongList
{
    public partial class Form1 : Form
    {
        //private List<Song> _songs = [];
        private AppDbContext _db = new AppDbContext();

        public Form1()
        {
            InitializeComponent();

            _db.Database.EnsureCreated();

            // Songs 테이블이 비어있으면 초기 데이터 추가
            if (!_db.Songs.Any())
            {
                List<Song> initialSongs = [
                    new("Blue Hour", "LUNA8", 5),
                    new("도깨비불 (Ghostfire)", "X-CROSS", 4),
                    new("Spicy Love", "Cherry Bomb", 5),
                    new("신기루 (Mirage)", "ONE-WAY", 3),
                    new("Hypnotized", "NEXUS", 4),
                    new("첫사랑 법칙 (First Love Rule)", "Pureum", 5),
                    new("Black Out", "Viper", 4),
                    new("한여름 밤의 꿈 (Midsummer)", "SOLO", 5),
                    new("Cyberpunk", "GLITCH", 4),
                    new("별자리 (Constellation)", "Aura", 3),
                    new("Bad Boy, Good Girl", "TRIGGER", 5),
                    new("소리쳐 (Shout Out)", "ZEAL", 4),
                    new("Velvet Dress", "Siren", 5),
                    new("그림자놀이 (Shadow)", "ECLIPSE", 4),
                    new("Neon City", "Beat Runners", 3),
                    new("비밀정원 (Secret)", "Fairy Tale", 5),
                    new("Crash Landing", "Sledge", 4),
                    new("눈이 부시게 (Blinding)", "DAWN", 5),
                    new("Wildfire", "ASHE", 4),
                    new("시간을 달려서 (Time Warp)", "Nova", 4)
                ];

                _db.Songs.AddRange(initialSongs);
                _db.SaveChanges();
            }

            LoadSongs();
        }

        private void LoadSongs()
        {
            listSong.Items.Clear();

            var filteredSongs = _db.Songs
                .Where(s => s.Rating >= 4)
                .OrderByDescending(s => s.Rating);

            foreach (var song in filteredSongs)
            {
                listSong.Items.Add(song);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string artist = txtArtist.Text.Trim();

            if (title.Length == 0 || artist.Length == 0)
            {
                MessageBox.Show("제목과 가수를 입력하세요.");
                return;
            }

            _db.Songs.Add(new Song(title, artist, (int)numRating.Value));
            _db.SaveChanges();

            txtTitle.Clear();
            txtArtist.Clear();
            numRating.Value = numRating.Maximum;
            txtTitle.Focus();

            LoadSongs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listSong.SelectedItem is not Song song)
            {
                MessageBox.Show("삭제할 노래를 선택하세요.");
                return;
            }

            if (MessageBox.Show($"'{song.Title}' 을(를) 삭제할까요?", "삭제 확인",
                    MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            _db.Songs.Remove(song);
            _db.SaveChanges();

            LoadSongs();
        }

        private void btnKaraoke_Click(object sender, EventArgs e)
        {
            if (listSong.SelectedItem is not Song song)
            {
                MessageBox.Show("노래를 선택하세요.");
                return;
            }

            // 선택한 곡의 "제목 가수 노래방" 으로 YouTube 검색 결과를 기본 브라우저에서 연다
            string query = Uri.EscapeDataString($"{song.Title} {song.Artist} 노래방");
            Process.Start(new ProcessStartInfo(
                $"https://www.youtube.com/results?search_query={query}")
            {
                UseShellExecute = true
            });
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public record Song(string Title, string Artist, int Rating)
    {
        // Id는 DB에서 부여하고, 수정은 막기 위해 set 대신 init 사용
        [Key]
        public int Id { get; init; }

        public override string ToString() => $"{Title} - [{Artist}] (⭐{Rating})";
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // songs.db 파일로 저장
            optionsBuilder.UseSqlite("Data Source=songs.db");
        }
    }
}
