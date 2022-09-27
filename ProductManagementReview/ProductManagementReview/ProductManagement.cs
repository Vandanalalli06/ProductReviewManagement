using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReviewManagementUsingLinq
{
    public class ProductManagement
    {
        public void GetTopThreeRecords(List<ProductReview> productReviewList)
        {
            // Linq query to retrieve top three having high ratings
            var recordedData = (from prodctReviews in productReviewList
                                orderby prodctReviews.Rating descending
                                select prodctReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId :-" + list.ProductID + " " + "UserId:-" + list.UserID + " " + "Rating :-" + " "
                    + list.Rating + " " + "Review :-" + list.Review + " " + "isLike :-" + list.isLike);
            }
        }
        /// <summary>
        /// Retriving records whose ratings >3 and ProductID=1 or 4 or 9
        /// //<ProductReviewManagementUsingLinq.ProductReview>
        /// </summary>
        /// <param name="productReviewList"></param>

        public void GetRecords(List<ProductReview> productReviewList)
        {
            // Linq query to retrieve records with given condition
            IEnumerable<ProductReview> recordedData = (from productsL in productReviewList
                                                       where (productsL.Rating > 3) && (productsL.ProductID == 1 || productsL.ProductID == 4 ||
                                                       productsL.ProductID == 9)
                                                       select productsL);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId :-" + list.ProductID + " " + "UserId:-" + list.UserID + " " + "Rating :-" + " " + list.Rating + " "
                + "Review :-" + list.Review + " " + "isLike :-" + list.isLike);
            }
        }
    }
}