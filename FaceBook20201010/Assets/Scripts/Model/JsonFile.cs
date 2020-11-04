using System;
using UnityEngine;
using UnityEngine.UI;

// key 親
[Serializable] public class TestJsonParent
{
    public TestJsonChild[] data;
}

// key 子
    [Serializable] public class TestJsonChild
    {
        public int id;
        public string userName; 
        public string iconImage; 
        public string postingTimeText; //XX時間前・
        public string postText;  
        public string postImage;
        public string stampButtonText;  //あなた、他XXXX人
        public string postDetailText;   //コメントXX件　　シェアXX件
       
        public string commentIconImage;
        public string commentText;
        public string storyPreview;  //ストーリープレビュー
        public string headerName;  //TWICE's Post

        public string shareText; //56 Shares
        public string storyPostingTimeText; //5m (Stroyの時間)

        //_Group
        public string groupName;
        public string groupIcon;
        //PageObject
        public string occupationText;
        public string peopleLikeText;
        public string topFansText;
        public string webText;
        public string headerImage;


        




        
    }