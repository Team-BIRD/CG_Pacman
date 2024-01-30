using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace ThePrototype.Scripts
{
    public class GameManager : MonoBehaviour
    {
        [Header("References")] [SerializeField]
        private List<GhostController> _ghosts;

        [SerializeField] private PlayerController _player;
        [SerializeField] private Transform _pellets;

        [Header("Settings")] [SerializeField] private int _initialLive;

        private int Live { get; set; }
        private int Score { get; set; }

        private void Start()
        {
            _player.OnTakePoint += SetScore;
            NewGame();
            NewRound();
        }

        private void SetScore(int point)
        {
            Score += point;
        }

        private void NewRound()
        {
            foreach (Transform pellet in _pellets)
            {
                pellet.gameObject.SetActive(true);
            }

            ResetState();
        }

        private void ResetState()
        {
            SetActivation(true);
        }

        private void GameOver()
        {
            SetActivation(false);
        }

        private void SetActivation(bool state)
        {
            _player.ActivationState(state);
            _ghosts.ForEach(x => x.ActivationState(state));
        }

        private void NewGame()
        {
            Live = _initialLive;
            Score = 0;
        }
    }
}