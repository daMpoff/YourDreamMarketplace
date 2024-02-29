namespace YourDreamMarketplace
{
    public class Review
    {
        private byte stars;
        private int idReview, idUser;
        private DateTime dateOfReview;
        public int IdReview
        {
            get
            {
                return idReview;
            }
            set
            {
                if (value > 0)
                {
                    idReview = value;
                }
                else
                {
                    throw new ArgumentException("Ошибка, Id меньше 0!");
                }
            }
        }
        public int IdUser
        {
            get
            {
                return idUser;
            }
            set
            {
                if (value > 0)
                {
                    idUser = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Ошибка, ID пользователя не может быть меньше 0!");
                }
            }
        }
        public DateTime DateOfReview
        {
            get
            {
                return dateOfReview;
            }
            set
            {
                if (dateOfReview > DateTime.MinValue && dateOfReview < DateTime.MaxValue)
                {
                    dateOfReview = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Ошибка, дата отзыва указана неверно!");
                }
            }
        }
        public byte Stars
        {
            get
            {
                return stars;
            }
            set
            {
                if (value > 0 && value <= 5)
                {
                    stars = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Ошибка, Рейтинг не может быть меньше 0 или меньше 5!");
                }
            }
        }
    }
}
