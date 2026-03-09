using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestQuest : MonoBehaviour
{
    public class Player // 플레이어
    {
        private int level; // private 유지할 것

        public int GetLevel()  // [해결] 어떻게? 레벨이 얼마인지 "알려주기만" 하는 공개 스킬(함수)을 만든다!
        {
            return level; // private 숫자를 복사해서 밖으로 던져줌!
        }
    }

    public class Monster // 몬스터
    {
        private int level;

        public void SetLevel(int _playerLevel)
        {
            level = _playerLevel; // 매개변수 지정 + 전달받은 숫자로 내 레벨을 정함
        }
    }

    public class Game // 인게임
    {
        Player player;
        Monster monster;

        public void Test()
        {
            monster.SetLevel(player.GetLevel()); // Player의 private level을 복사해서 public으로 던져주는 함수를 연결
            // player.GetLevel() = 0; 조작 불가능! 
        }
    }
}

// 힌트 : 함수를 만들고 반환값을 설정...? 
