//
//  UserScoreTableCell.h
//  HashGag
//
//  Created by Rob Struthers on 09/02/2014.
//  Copyright (c) 2014 HashGag. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface UserScoreTableCell : UITableViewCell
@property (strong, nonatomic) IBOutlet UILabel *scoreLabel;
@property (strong, nonatomic) IBOutlet UILabel *timeLabel;
@property (strong, nonatomic) IBOutlet UILabel *hashtagLabel;
@property (strong, nonatomic) IBOutlet UIImageView *userImage;

@end
