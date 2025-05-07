using System.ComponentModel.DataAnnotations;

namespace EF_Board.Models
{
    /// <summary>
    /// 게시글 작성자(User)를 나타내는 엔티티입니다.
    /// 사용자 이름, 이메일, 게시글 목록을 포함합니다.
    /// </summary>
    public class User
    {
        /// <summary>
        /// 사용자의 고유 ID입니다. 기본 키 역할을 합니다.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 사용자 이름입니다. 필수 항목이며 최대 100자까지 입력 가능합니다.
        /// </summary>
        [Required] // 필수 입력 항목입니다.
        [MaxLength(100)] // 최대 100자 제한
        public string UserName { get; set; } = string.Empty;

        /// <summary>
        /// 사용자 이메일입니다. 필수 항목입니다.
        /// </summary>
        [Required]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// 사용자가 작성한 게시글 목록입니다. 1:N 관계에서 N에 해당합니다.
        /// </summary>
        // ICollection<T>: 여러 개의 Post를 담을 수 있는 컬렉션입니다.
        // 나중에 User.Posts 형태로 해당 사용자의 모든 글을 조회할 수 있습니다.
        public ICollection<Post> Posts { get; set; } = [];
    }
}
