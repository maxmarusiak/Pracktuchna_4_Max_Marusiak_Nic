using System;
using System.Text;

namespace StudentGroupSystem.Models
{
    public class Student
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        private string _fullName;
        public string FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ПІБ не може бути порожнім.");

                var parts = value.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length < 3)
                    throw new ArgumentException("ПІБ має містити мінімум три слова: Прізвище Ім’я По батькові.");

                _fullName = value.Trim();
            }
        }

        public byte[] LabGrades { get; set; } = new byte[10];

        public string Notes { get; set; } = "";

        public Student(string fullName)
        {
            FullName = fullName;
        }

        public bool ContainsKeyword(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return false;

            keyword = keyword.ToLower();

            return FullName.ToLower().Contains(keyword)
                || Notes.ToLower().Contains(keyword);
        }

        public string GetFormattedInfo(bool detailed = false)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"ПІБ: {FullName}");
            sb.AppendLine($"ID: {Id}");

            if (detailed)
            {
                sb.AppendLine($"Оцінки: {string.Join(", ", LabGrades)}");
                sb.AppendLine($"Нотатки: {Notes}");
            }

            return sb.ToString();
        }
    }
}
