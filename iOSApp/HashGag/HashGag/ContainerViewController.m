//
//  ContainerViewController.m
//  HashGag
//
//  Created by Rob Struthers on 09/02/2014.
//  Copyright (c) 2014 HashGag. All rights reserved.
//

#import "ContainerViewController.h"

#define SegueIdentifierWinning @"winningSegue"
#define SegueIdentifierLosing @"losingSegue"

@interface ContainerViewController ()
@property (strong, nonatomic) NSString *currentSegueIdentifier;
@end

@implementation ContainerViewController

- (void)viewDidLoad
{
    [super viewDidLoad];
	self.currentSegueIdentifier = SegueIdentifierWinning;
    [self performSegueWithIdentifier:self.currentSegueIdentifier sender:nil];
}

- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender
{
    if ([segue.identifier isEqualToString:SegueIdentifierWinning])
    {
        if (self.childViewControllers.count > 0) {
            [self swapFromViewController:[self.childViewControllers objectAtIndex:0] toViewController:segue.destinationViewController];
        }
        else {
            [self addChildViewController:segue.destinationViewController];
            ((UIViewController *)segue.destinationViewController).view.frame = CGRectMake(0, 0, self.view.frame.size.width, self.view.frame.size.height);
            [self.view addSubview:((UIViewController *)segue.destinationViewController).view];
            [segue.destinationViewController didMoveToParentViewController:self];
        }
    }
    else if ([segue.identifier isEqualToString:SegueIdentifierLosing])
    {
        [self swapFromViewController:[self.childViewControllers objectAtIndex:0] toViewController:segue.destinationViewController];
    }
}

- (void)swapFromViewController:(UIViewController *)fromViewController toViewController:(UIViewController *)toViewController
{
    toViewController.view.frame = CGRectMake(0, 0, self.view.frame.size.width, self.view.frame.size.height);
    
    [fromViewController willMoveToParentViewController:nil];
    [self addChildViewController:toViewController];
    [self transitionFromViewController:fromViewController toViewController:toViewController duration:1.0 options:UIViewAnimationOptionTransitionCrossDissolve animations:nil completion:^(BOOL finished) {
        [fromViewController removeFromParentViewController];
        [toViewController didMoveToParentViewController:self];
    }];
}

- (void)swapViewControllers
{
    self.currentSegueIdentifier = (self.currentSegueIdentifier == SegueIdentifierWinning) ? SegueIdentifierLosing : SegueIdentifierWinning;
    [self performSegueWithIdentifier:self.currentSegueIdentifier sender:nil];
}


- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
