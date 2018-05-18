        public List<object> SchedleMenuPageno(int pageno)
        {
            int pagevaluesize = 10;

            var menuScheduleAlldata = _menuScheduleRepository.GetAll().ToList();
            int count = menuScheduleAlldata.Count();

            int totalpage = (int)Math.Ceiling(count / (double)pagevaluesize);
            var items = menuScheduleAlldata.Skip((pageno - 1) * pagevaluesize).Take(pagevaluesize).ToList();

            var previousPage = pageno > 1 ? "Yes" : "No";
            var nextPage = pageno < totalpage ? "Yes" : "No";

            return new List<object>(items);

        }

        /**Api method for pagination of schedleManu julhas ends here**/

        /*Api method for pagination of schedlemenu with date starts here*/
        public List<object> SchedleMenuPagenoDate(int pageno, string date)
        {
            var datetime = Convert.ToDateTime(date);
            int pagevaluesize = 10;

            var menuScheduleAlldata = _menuScheduleRepository.GetAll().ToList();
            int count = menuScheduleAlldata.Count();

            int totalpage = (int)Math.Ceiling(count / (double)pagevaluesize);
            var items = menuScheduleAlldata.Skip((pageno - 1) * pagevaluesize).Take(pagevaluesize).Where(x=>x.Date == datetime).ToList();


            var previousPage = pageno > 1 ? "Yes" : "No";
            var nextPage = pageno < totalpage ? "Yes" : "No";

            return new List<object>(items);
        }
        /*Api method for pagination of schedlemenu with date ends here*/

         /*Api Method for pagination of schedluemenu with pageno and mealid starts here*/
        public List<object> SchedleMenuPagenoMealid(int pageno, int mealid)
        {
          
            int pagevaluesize = 10;

            var menuScheduleAlldata = _menuScheduleRepository.GetAll().ToList();
            int count = menuScheduleAlldata.Count();

            int totalpage = (int)Math.Ceiling(count / (double)pagevaluesize);
            var items = menuScheduleAlldata.Skip((pageno - 1) * pagevaluesize).Take(pagevaluesize).Where(x => x.MealId == mealid).ToList();


            var previousPage = pageno > 1 ? "Yes" : "No";
            var nextPage = pageno < totalpage ? "Yes" : "No";

            return new List<object>(items);
        }
        /*Api Method for pagination of schedluemenu with pageno and mealid ends here*/