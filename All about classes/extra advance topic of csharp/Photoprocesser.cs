using System;


namespace extra_advance_topic_of_csharp
{
    public class Photoprocesser
    {
        public void Process(string path)
        {
            var photo = Photo.Load(path);
            var filter = new PhotoFilter();
            filter.ApplyBrightness(photo);
            filter.ApplyConstrast(photo);
            filter.Resize(photo);
            photo.save();


        }

    }
}
