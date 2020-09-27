
 


import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Container;
import java.awt.Graphics;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.awt.event.MouseMotionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.io.File;
import javax.swing.JColorChooser;
import javax.swing.JFileChooser;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JPanel;


public class save extends PAINT2 {
    
      JLabel jl;
 
    Color c;
    int x1, y1, x2, y2;
    String msg = " ";
    int mouseX = 0, mouseY = 0;
    JFileChooser fc;
    File file;

    public save (){


    Container cont = new Container();
    jl = new JLabel(" ");
    JPanel pbuttons = new JPanel();
    DrawingBoard drp = new DrawingBoard();
  
    JPanel pStatus = new JPanel();

    fc = new JFileChooser();

    pbuttons.setLayout(new GridLayout(9, 2));
    GridLayout gl = new GridLayout(9, 2);


    JMenuBar mbr = new JMenuBar();
    setJMenuBar(mbr);
    JMenu file = new JMenu("FILE");
    JMenu edit = new JMenu("EDIT");
    JMenu view = new JMenu("VIEW");
    JMenu image = new JMenu("IMAGE");
    JMenu colors = new JMenu("COLORS");
    JMenu help = new JMenu("HELP");

    JMenuItem mit, mit1, mit2, mit3, mit4;
    file.add(mit = new JMenuItem("new"));
    file.add(mit1 = new JMenuItem("open"));
    file.add(mit2 = new JMenuItem("save"));
    file.add(mit3 = new JMenuItem("save as"));
    file.add(mit4 = new JMenuItem("exit"));

    JMenuItem mit5, mit6, mit7, mit8, mit9;
    edit.add(mit5 = new JMenuItem("undo"));
    edit.add(mit6 = new JMenuItem("redo"));
    edit.add(mit7 = new JMenuItem("cut"));
    edit.add(mit8 = new JMenuItem("copy"));
    edit.add(mit9 = new JMenuItem("paste"));

    JMenuItem bc;
    colors.add(bc = new JMenuItem("setbackground"));
    bc.addActionListener(new MyAction());

  

    mit.addActionListener(new MyAction());
    mit1.addActionListener(new MyAction());
    mit2.addActionListener(new MyAction());
    mit3.addActionListener(new MyAction());
    mit4.addActionListener(new MyAction());
    mit5.addActionListener(new ActionListener() {

    @Override
    public void actionPerformed(ActionEvent ae) {
    jl.setText("undo is clicked");
    }
    });

    mit6.addActionListener(new ActionListener() {

    @Override
    public void actionPerformed(ActionEvent ae) {
    jl.setText("redo is clicked");
    }
    });

    mit7.addActionListener(new ActionListener() {

    @Override
    public void actionPerformed(ActionEvent ae) {
    

    }
    });
    mit8.addActionListener(new ActionListener() {

    @Override
    public void actionPerformed(ActionEvent ae) {
    jl.setText("copy as is clicked");
    }
    });
    mit9.addActionListener(new ActionListener() {

    @Override
    public void actionPerformed(ActionEvent ae) {
    jl.setText("paste is clicked");
    }
    });


    mbr.add(file);
    mbr.add(edit);
    mbr.add(view);
    mbr.add(image);
    mbr.add(colors);
    mbr.add(help);
    cont = getContentPane();
    cont.setLayout(new BorderLayout());
    cont.add(mbr, BorderLayout.NORTH);
    cont.add(pbuttons, BorderLayout.NORTH);
    //cont.add(drp,BorderLayout.CENTER);
    cont.add(jl, BorderLayout.NORTH);


  
    setVisible(true);
    } 




    class DrawingBoard extends JPanel implements ActionListener 
    {
    int chr=0;

    DrawingBoard()
    {
    MouseHandler handler = new MouseHandler();
    this.addMouseListener(handler);
    this.addMouseMotionListener(handler);

    addWindowListener (
    new WindowAdapter () 
    {
    @Override
    public void windowClosing (WindowEvent e) 
    {
    System.exit(0);
    }

    }
    );



    }  

   

        @Override
        public void actionPerformed(ActionEvent e) {
            throw new UnsupportedOperationException("Not supported yet.");
        }
    }

   
    public class MyAction implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent ae) {
    String str = ae.getActionCommand();
    if (str.equals("new")) {

    }
    if (str.equals("open")) {
    int returnVal = fc.showOpenDialog(save.this);
    if (returnVal == JFileChooser.APPROVE_OPTION) {
    File file = fc.getSelectedFile();
    } else {
    } 
    }
    if (str.equals("save")) {
    int returnVal = fc.showSaveDialog(save.this);
    if (returnVal == JFileChooser.APPROVE_OPTION) {
    File file = fc.getSelectedFile();
    } else {
    } 
    }

    if (str.equals("save as")) {
    int returnVal = fc.showSaveDialog(save.this);
    if (returnVal == JFileChooser.APPROVE_OPTION) {
    File file = fc.getSelectedFile();
    } else {
    }
    }
    if (str.equals("setbackground")) {
    Color c = JColorChooser.showDialog(
    save.this, "Choose a color...", getBackground());
    if (c != null) {
    getContentPane().setBackground(c);
    }
    }
    if (str.equals("exit")) {
    System.exit(0);

    }
    }
    }
    /*----------------------------------------------------------------------------*/
    private class MouseHandler implements MouseListener, MouseMotionListener
    {
    @Override
    public void mouseClicked(MouseEvent me)
    {
  
    jl.setText("mouse clicked");

    }
    @Override
    public void mouseEntered(MouseEvent me)
    {
     mouseX=0;
     mouseY=0;
    jl.setText("mouse enetered");
    
    } 
    @Override
    public void mouseExited(MouseEvent me)
    {
    mouseX=0;
    mouseY=0;
    jl.setText("mouse exited");
    repaint();
    }
    @Override
    public void mousePressed(MouseEvent me)
    {
    mouseX=me.getX();
    x1=mouseX; 
    mouseY=me.getY();
    y1=mouseY;
    jl.setText( mouseX + " , " + mouseY);
    repaint();
    }
    @Override
    public void mouseReleased(MouseEvent me)
    {
    mouseX=me.getX(); 
    x2=mouseX; 
    mouseY=me.getY();
    y2=mouseY;
    jl.setText(mouseX + " , " + mouseY);
    repaint();
    }
    @Override
    public void mouseDragged(MouseEvent me)
    {
    mouseX=me.getX();
    mouseY=me.getY();
    msg="*";
    jl.setText("Draggingmouse at " + mouseX + " , " + mouseY);
    
    }
    @Override
    public void mouseMoved(MouseEvent me)
    {
    jl.setText("movingmouse at " + me.getX() + " , " + me.getY());
    }
    public void paint(Graphics g)
    {
    g.drawString(" ",mouseX,mouseY);
    }
    }


    public void actionPerformed(ActionEvent ae) {
    }


    }



    
    
    

