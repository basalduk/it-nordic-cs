namespace L13_C04_interface.Interface
{
	public interface IVideoPlayer
	{
		string VideoSource { get; set; }

		void PlayVideo();
	}
}
