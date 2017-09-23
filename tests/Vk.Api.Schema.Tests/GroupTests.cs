using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Vk.Api.Schema.Common.Group;
using System.Linq;

namespace Vk.Api.Schema.Tests
{
    [TestClass]
    public class GroupTests
    {
        private readonly string jsonPage = @"{""id"":103562966,""name"":""ExtremeCode"",""screen_name"":""extremecodetv"",""is_closed"":0,""type"":""page"",""is_admin"":1,""admin_level"":3,""is_member"":1,""description"":""2 успешных (нет) разработчика - iPro (Artem Dontsov) и Misteri0 (Nikolay Desyatkov) научат вас правильно программировать на C#, а так же расскажут об опыте разработки, методологиях программирования и прочих полезных штуках. И да, все это приправлено отборными шутеечками"",""members_count"":1877,""counters"":{""photos"":17,""albums"":2,""topics"":3,""videos"":11},""start_date"":20120101,""can_post"":1,""can_see_all_posts"":1,""activity"":""Интернет"",""status"":""Мы за всё хорошее и против всего плохого 👌"",""contacts"":[{""user_id"":80981913,""desc"":""Местный ленивец""},{""user_id"":262632225,""desc"":""Не в сети""}],""links"":[{""id"":94394164,""url"":""https://www.youtube.com/channel/UCBNlINWfd08qgDkUTaUY4_w"",""edit_title"":1,""name"":""ExtremeCode"",""desc"":""www.youtube.com"",""photo_50"":""https://pp.userapi.com/c837123/v837123225/42713/jcj17xfwmik.jpg"",""photo_100"":""https://pp.userapi.com/c837123/v837123225/42714/TgN9fssxic4.jpg""},{""id"":94394188,""url"":""https://t.me/extremecode"",""edit_title"":1,""name"":""Чат"",""desc"":""t.me"",""photo_50"":""https://pp.userapi.com/c837123/v837123225/42719/Q7ZdcMsgins.jpg"",""photo_100"":""https://pp.userapi.com/c837123/v837123225/4271a/InMu-_PLPNM.jpg""},{""id"":86514232,""url"":""https://twitter.com/ExtremeCodeTV"",""edit_title"":1,""name"":""@ExtremeCodeTV"",""desc"":""twitter.com"",""photo_50"":""https://pp.userapi.com/c636617/v636617225/328d3/RnkuLObdRd0.jpg"",""photo_100"":""https://pp.userapi.com/c636617/v636617225/328d4/CN68UIKfhlQ.jpg""},{""id"":86375819,""url"":""https://github.com/extremecodetv/"",""edit_title"":1,""name"":""GitHub"",""desc"":""github.com"",""photo_50"":""https://pp.userapi.com/c626417/v626417225/2ce20/nKCTtpjFFw4.jpg"",""photo_100"":""https://pp.userapi.com/c626417/v626417225/2ce21/SdxHr3Fzzoc.jpg""}],""fixed_post"":1269,""verified"":0,""site"":"""",""can_create_topic"":1,""photo_50"":""https://pp.userapi.com/c638420/v638420225/3a252/45rZsIMxoJk.jpg"",""photo_100"":""https://pp.userapi.com/c638420/v638420225/3a251/2D8W7s4JnlY.jpg"",""photo_200"":""https://pp.userapi.com/c638420/v638420225/3a250/LG3zlZpi7GQ.jpg""}";

        //TODO: Block status, invited by, age limits, ban info, city, cover, favorite, 
        // is hidden from feed, is messages blocked, main album id, main section, market info
        // place, finish date, wiki-page, public date label, photos

        [TestMethod]
        public void TestGroupBaseInfo()
        {
            var exceptedId = 103562966;
            var exceptedName = "ExtremeCode";
            var exceptedScreenName = "extremecodetv";
            var exceptedIsClosed = Enums.Group.GroupClosedType.Open;
            var exceptedType = Enums.Group.GroupType.Page;
            var exceptedIsAdmin = true;
            var exceptedAdminLevel = Enums.Group.AdminLevel.Administrator;
            var exceptedIsMember = true;
            var exceptedDescription = "2 успешных (нет) разработчика - iPro (Artem Dontsov) и Misteri0 (Nikolay Desyatkov) научат вас правильно программировать на C#, а так же расскажут об опыте разработки, методологиях программирования и прочих полезных штуках. И да, все это приправлено отборными шутеечками";
            var exceptedMembersCount = 1877;
          
            var result = JsonConvert.DeserializeObject<Group>(jsonPage);

            Assert.AreEqual(exceptedId, result.Id);
            Assert.AreEqual(exceptedName, result.Name);
            Assert.AreEqual(exceptedScreenName, result.ScreenName);
            Assert.AreEqual(exceptedIsClosed, result.Closed);
            Assert.AreEqual(exceptedIsAdmin, result.IsAdmin);
            Assert.AreEqual(exceptedAdminLevel, result.Level);
            Assert.AreEqual(exceptedIsMember, result.IsMember);
            Assert.AreEqual(exceptedDescription, result.Description);
            Assert.AreEqual(exceptedMembersCount, result.MembersCount);
            Assert.AreEqual(exceptedType, result.Type);
        }

        [TestMethod]
        public void TestGroupCounters()
        {
            var exceptedPhotosCount = 17;
            var exceptedAlbumsCount = 2;
            var exceptedTopicsCount = 3;
            var exceptedVideosCount = 11;

            var result = JsonConvert.DeserializeObject<Group>(jsonPage);

            Assert.AreEqual(exceptedAlbumsCount, result.Counters.AlbumsCount);
            Assert.AreEqual(exceptedPhotosCount, result.Counters.PhotosCount);
            Assert.AreEqual(exceptedTopicsCount, result.Counters.TopicsCount);
            Assert.AreEqual(exceptedVideosCount, result.Counters.VideosCount);

            Assert.AreEqual(null, result.Counters.DocsCount);
            Assert.AreEqual(null, result.Counters.AudiosCount);
        }

        [TestMethod]
        public void TestGroupLinks()
        {
            var exceptedLinksCount = 4;

            var exceptedLinkId = 94394164;
            var exceptedLinkUrl = new Uri("https://www.youtube.com/channel/UCBNlINWfd08qgDkUTaUY4_w");
            var exceptedLinkEditTitle = true;
            var exceptedLinkName = "ExtremeCode";
            var exceptedLinkDesc = "www.youtube.com";
            var exceptedLinkPhoto50 = new Uri("https://pp.userapi.com/c837123/v837123225/42713/jcj17xfwmik.jpg");
            var exceptedLinkPhoto100 = new Uri("https://pp.userapi.com/c837123/v837123225/42714/TgN9fssxic4.jpg");
            
            var result = JsonConvert.DeserializeObject<Group>(jsonPage);

            var actualLinksCount = result.Links.Count();
            var actualLink = result.Links.FirstOrDefault();

            Assert.AreEqual(exceptedLinksCount, actualLinksCount);
            Assert.AreNotEqual(null, actualLink);

            Assert.AreEqual(exceptedLinkId, actualLink.Id);
            Assert.AreEqual(exceptedLinkUrl, actualLink.Url);
            //Assert.AreEqual(exceptedLinkEditTitle, actualLink.) //TODO: Implement
            Assert.AreEqual(exceptedLinkName, actualLink.Name);
            Assert.AreEqual(exceptedLinkDesc, actualLink.Description);
            Assert.AreEqual(exceptedLinkPhoto50, actualLink.Photo50);
            Assert.AreEqual(exceptedLinkPhoto100, actualLink.Photo100);
        }

        [TestMethod]
        public void TestGroupContacts()
        {
            var exceptedContactsCount = 2;
            var exceptedContactUserId = 80981913;
            var exceptedContactPosition = "Местный ленивец";

            var result = JsonConvert.DeserializeObject<Group>(jsonPage);

            var actualContactsCount = result.Contacts.Count();
            var actualContact = result.Contacts.FirstOrDefault();

            Assert.AreEqual(exceptedContactsCount, actualContactsCount);
            Assert.AreEqual(exceptedContactUserId, actualContact.UserId);
            Assert.AreEqual(exceptedContactPosition, actualContact.Position);

            //TODO: Phone and email
        }

        [TestMethod]
        public void TestGroupOther()
        {
            var exceptedStartDate = new DateTime()
                .AddYears(1969);

            var exceptedCanPost = true;
            var exceptedCanSeeAllPosts = true;
            var exceptedActivity = "Интернет";
            var exceptedStatus = "Мы за всё хорошее и против всего плохого 👌";

            var exceptedFixedPost = 1269;
            var exceptedVerified = false;
            Uri exceptedSite = null;

            var exceptedCanCreateTopic = true;

            var exceptedPhoto50 = new Uri("https://pp.userapi.com/c638420/v638420225/3a252/45rZsIMxoJk.jpg");
            var exceptedPhoto100 = new Uri("https://pp.userapi.com/c638420/v638420225/3a251/2D8W7s4JnlY.jpg");
            var exceptedPhoto200 = new Uri("https://pp.userapi.com/c638420/v638420225/3a250/LG3zlZpi7GQ.jpg");
            
            var result = JsonConvert.DeserializeObject<Group>(jsonPage);

            Assert.AreEqual(exceptedStartDate.Year, result.StartDate.Value.Year);
            Assert.AreEqual(exceptedCanPost, result.CanPost);
            Assert.AreEqual(exceptedCanSeeAllPosts, result.CanSeeAllPosts);
            Assert.AreEqual(exceptedActivity, result.Activity);
            Assert.AreEqual(exceptedStatus, result.Status);
            Assert.AreEqual(exceptedFixedPost, result.FixedPost);
            Assert.AreEqual(exceptedSite, result.Url);
            Assert.AreEqual(exceptedVerified, result.IsVerified);
            Assert.AreEqual(exceptedCanCreateTopic, result.CanCreateTopic);
            ///Assert.AreEqual(exceptedPhoto50, result. //TODO: Photos
        }        
    }
}
