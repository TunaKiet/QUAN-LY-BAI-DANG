using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_quan_ly_bai_dang
{
    public class PostNode
    {
        public Post Post { get; set; }
        public PostNode Next { get; set; }
        public PostNode(Post post)
        {
            Post = post;
            Next = null;
        }

    }
    //Định nghĩa lớp cho bài đăng
    public class Post
    {
        public string Tittle { get; set; }
        public string Content { get; set; }
        public DateTime PostAt { get; set; }

        public string UserName { get; set; }
        public Post(string tittle, string content, string username)
        {
            Tittle = tittle;
            Content = content;
            UserName = username;
            PostAt = DateTime.Now;
        }
    }
    //Triển khai lớp quản lý danh sách bài đăng 
    public class PostManager
    {
        private PostNode head;
        public void AddPost(Post post)
        {
            PostNode newNode = new PostNode(post);
            if (head == null)
            {
                newNode = head;
            }
            else
            {
                PostNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        //Xoa bai dang, tim kiem bai dang, cap nhat bai dang,...
        public void Update(Post post)
        {
            PostNode current = head;
            while (current != null)
            {
                if (current.Post == post)
                {
                    current.Post.Tittle = post.Tittle;
                    current.Post.Content = post.Content;
                    break;
                }
                current = current.Next;
            }


        }
        public void FindPost(Post post)
        {
            PostNode current = head;
            while (current != null)
            {
                if (current.Post == post)
                {
                    Console.WriteLine("Đã tìm thấy");
                }
                else Console.WriteLine("Không tìm thấy");
            }
        }
        public void DeletePost(Post post)
        {
            PostNode current = head;
            PostNode previous = null;
            while (current != null)
            {
                if (current.Post == post)
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }
                    break;
                }
                previous = current;
                current = current.Next;
            }
        }
    }
}
