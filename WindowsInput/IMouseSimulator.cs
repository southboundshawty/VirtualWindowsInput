using System;

namespace WindowsInput
{
    public interface IMouseSimulator
    {
        IKeyboardSimulator Keyboard { get; }

        IMouseSimulator HorizontalScroll(int scrollAmountInClicks);

        IMouseSimulator LeftButtonClick();

        IMouseSimulator LeftButtonDoubleClick();

        IMouseSimulator LeftButtonDown();

        IMouseSimulator LeftButtonUp();

        IMouseSimulator MoveMouseBy(int pixelDeltaX, int pixelDeltaY);

        IMouseSimulator MoveMouseTo(double absoluteX, double absoluteY);

        IMouseSimulator MoveMouseToPositionOnVirtualDesktop(double absoluteX, double absoluteY);

        IMouseSimulator RightButtonClick();

        IMouseSimulator RightButtonDoubleClick();

        IMouseSimulator RightButtonDown();

        IMouseSimulator RightButtonUp();

        IMouseSimulator Sleep(int millsecondsTimeout);

        IMouseSimulator Sleep(TimeSpan timeout);

        IMouseSimulator VerticalScroll(int scrollAmountInClicks);

        IMouseSimulator XButtonClick(int buttonId);

        IMouseSimulator XButtonDoubleClick(int buttonId);

        IMouseSimulator XButtonDown(int buttonId);

        IMouseSimulator XButtonUp(int buttonId);
    }
}