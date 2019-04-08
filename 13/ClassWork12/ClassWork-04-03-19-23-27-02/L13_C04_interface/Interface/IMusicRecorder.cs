using System;

namespace L13_C04_interface.Interface
{
	public interface IMusicRecorder
	{
		string RecordingDestination { get; set; }

		void RecordMusic(TimeSpan duration);
	}
}
