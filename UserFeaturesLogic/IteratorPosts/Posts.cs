using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace UserFeaturesLogic
{
    internal class Posts : IAggregate
    {
        private readonly List<Post> m_UserPosts;

        public Posts(BasicFacebookFeatures i_UserPosts)
        {
            m_UserPosts = i_UserPosts.UserPosts;
        }

        public IIterator CreateIterator()
        {
            return new PostsIterator(this);
        }

        private class PostsIterator : IIterator
        {
            private Posts m_Agregate;
            private int m_CurrentIdx = -1;
            private int m_Count = -1;

            public PostsIterator(Posts i_Collection)
            {
                m_Agregate = i_Collection;
                m_Count = m_Agregate.m_UserPosts.Count;
            }

            public void Reset()
            {
                m_CurrentIdx = -1;
            }

            public bool MoveNext()
            {
                if (m_Count != m_Agregate.m_UserPosts.Count)
                {
                    throw new Exception("Collection can not be changed during iteration!");
                }

                if (m_CurrentIdx >= m_Count)
                {
                    throw new Exception("Already reached the end of the collection");
                }

                return ++m_CurrentIdx < m_Agregate.m_UserPosts.Count;
            }

            public object Current
            {
                get { return m_Agregate.m_UserPosts[m_CurrentIdx]; }
            }
        }
    }
}
