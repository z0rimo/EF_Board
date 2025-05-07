using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_Board.Models
{
    /// <summary>
    /// 게시판의 게시글(Post)을 나타내는 엔티티입니다.
    /// 제목, 내용, 작성자(User), 작성일, 수정일 정보를 포함합니다.
    /// </summary>
    public class Post
    {
        /// <summary>
        /// 게시글의 고유 ID입니다. 기본 키 역할을 합니다.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 게시글 제목입니다. 필수 항목이며 최대 200자까지 입력 가능합니다.
        /// </summary>
        [Required] // 해당 속성은 반드시 입력되어야 합니다. (NULL 불가)
        [MaxLength(200)] // 최대 길이를 200자로 제한합니다.
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 게시글 본문 내용입니다. 필수 항목입니다.
        /// </summary>
        [Required]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 작성자(User)의 ID입니다. 외래 키로 연결됩니다.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 작성자(User) 객체입니다. UserId와 연결되는 외래 키 관계입니다.
        /// </summary>
        [ForeignKey("UserId")] // UserId 속성을 외래 키로 지정합니다.
        public User User { get; set; } = default!;

        /// <summary>
        /// 게시글이 최초 작성된 날짜입니다. 기본값은 현재 시각입니다.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// 게시글이 마지막으로 수정된 날짜입니다. 수정 전에는 null일 수 있습니다.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
    }
}
