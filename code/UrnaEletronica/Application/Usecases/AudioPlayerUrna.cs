using Application.Interfaces;
using Core.Constants;
using Core.Interfaces;

namespace Application.Usecases
{
    internal class AudioPlayerUrna : IAudioPlayerUrna
    {
        private readonly string[] _caminhosDosAudios;
        private readonly IPlayerAudio _player;

        public AudioPlayerUrna(string[] caminhosDosAudios, IPlayerAudio player)
        {
            _caminhosDosAudios = caminhosDosAudios;
            _player = player;
        }

        public void Handle(AudiosDaUrna audio)
        {
            string caminhoDoAudio = _caminhosDosAudios[(int)audio];
            _player.Play(caminhoDoAudio);
        }
    }
}
